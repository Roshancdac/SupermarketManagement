﻿using CoreBusniess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesCases.UseCaseInterfaces
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}
