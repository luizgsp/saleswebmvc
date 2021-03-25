using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Services.Exceptions;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly SupplierService _supplierService;

        public ProductsController(ProductService productService, 
                                    CategoryService categoryService,
                                    SupplierService supplierService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _supplierService = supplierService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _productService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.FindAllAsync();
            var suppliers = await _supplierService.FindAllAsync();
            var viewModel = new ProductFormViewModel { Categories = categories, Suppliers = suppliers };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product obj)
        {
            if (!ModelState.IsValid)
            {
                var categories = await _categoryService.FindAllAsync();
                var suppliers = await _supplierService.FindAllAsync();
                var viewModel = new ProductFormViewModel { Categories = categories, Suppliers = suppliers };
                return View(viewModel);
            }
            await _productService.InsertAsync(obj);
            return RedirectToAction(nameof(Index));
        }
    }
}
