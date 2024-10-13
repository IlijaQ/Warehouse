﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApi.DataTransferClasses;
using WarehouseApi.Tools;
using WarehouseUI.DataTransferClasses;
using WarehouseUI.Models;

namespace WarehouseUI
{
    public static class UIController
    {
        public static async Task<List<Product>> GetProducts(SearchFilters filters)
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetProductsAsync(filters);
        }

        public static async Task<List<Category>> GetCategories()
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetCategoriesAsync();
        }

        public static async Task<bool> CreateProduct(Product product)
        {
            ApiRepository repository = new ApiRepository();
            ProductData productDto = TransferData.ProductToDto(product);
            bool success = await repository.CreateProductAsync(productDto);
            return success;
        }
    }
}