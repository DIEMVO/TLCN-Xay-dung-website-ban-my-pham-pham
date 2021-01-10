﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ApiIntegration;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Catalog.Products.Manage;
using WebMyPham.ViewModels.Common;
using WebMyPham.ViewModels.System.Products;

namespace WebMyPham.AdminApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient,
            IConfiguration configuration, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> Index(string name,string keyword, int? categoryId, int pageIndex = 1, int pageSize = 8)
        {
            var request = new GetManageProductPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId
            };

            var data = await _productApiClient.GetPagings(request);
            ViewBag.Keyword = keyword;

            var categories = await _categoryApiClient.GetAll();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.Id
            });

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.CreateProduct(request);
            if (result)
            {
                TempData["result"] = "Thêm mới sản phẩm thành công";
                return RedirectToAction("Index"); //chuyển đến phân trang 

            }

            ModelState.AddModelError("", "Thêm sản phẩm thất bại.");

            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var product = await _productApiClient.GetById(id);
            var editVm = new ProductUpdateRequest()
            {
                Id = product.Id,
                Description = product.Description,
                Details = product.Details,
                Name = product.Name,
                
            };
            return View(editVm);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var result = await _productApiClient.UpdateProduct(request);
            if (result)
            {
                TempData["result"] = "Cập nhật sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Cập nhật sản phẩm thất bại");
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> CategoryAssign(int id)
        {
            var categoryAssignRequest = await GetCategoryAssignRequest(id);
            return View(categoryAssignRequest);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.CategoryAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetCategoryAssignRequest(request.Id);

            return View(roleAssignRequest);
        }

        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(int id)
        {
            var productObj = await _productApiClient.GetById(id);
            var categories = await _categoryApiClient.GetAll();
            var categoryAssignRequest = new CategoryAssignRequest();
            foreach (var role in categories)
            {
                categoryAssignRequest.Categories.Add(new SelectItem()
                {
                    Id = role.Id.ToString(),
                    Name = role.Name,
                    Selected = productObj.Categories.Contains(role.Name)
                });
            }
            return categoryAssignRequest;
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(new ProductDeleteRequest()
            {
                Id = id
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductDeleteRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _productApiClient.DeleteProduct(request.Id);
            if (result)
            {
                TempData["result"] = "Xóa sản phẩm thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Xóa không thành công");
            return View(request);
        }
    }
}
