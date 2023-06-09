using Plugins.DataStore.InMemory;
using UsesCases;
using UsesCases.CategoriesUseCases;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.ProductUseCase;
using UsesCases.UseCaseInterfaces;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//Dependency Injection for In-Memory Data Store
builder.Services.AddScoped<ICategoryRepository, CategoryInMemoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductInMemeoryRepository>();

//Dependency Injection for Use Cases and Repositories
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IAddCategoryUseCase, AddCategoryUseCase>();
builder.Services.AddTransient<IEditCategoryUseCase, EditCategoryUseCase>();
builder.Services.AddTransient<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
builder.Services.AddTransient<IRemoveCategory, RemoveCategory>();
builder.Services.AddTransient<IViewProductsUseCase, ViewProductsUseCase>();
builder.Services.AddTransient<IAddProductUseCase, AddProductUseCase>();
builder.Services.AddTransient<IGetProductByIdUseCase, GetProductByIdUseCase>();
builder.Services.AddTransient<IRemoveProductUseCase, RemoveProductUseCase>();
builder.Services.AddTransient<IEditProductUseCase, EditProductUseCase>();
builder.Services.AddTransient<IViewProductByCategoryId, ViewProductByCategoryId>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
