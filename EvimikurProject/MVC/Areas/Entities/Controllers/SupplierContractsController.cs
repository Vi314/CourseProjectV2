using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Areas.Entities.Models.MapperAbstract;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Controllers
{
    [Area("Entities")]
    public class SupplierContractsController : Controller
    {
        private readonly ISupplierContractService _service;
        private readonly ISupplierContractMapper _mapper;
        private readonly ISupplierService _supplierService;

        public SupplierContractsController(ISupplierContractService service, ISupplierContractMapper mapper, ISupplierService supplierService)
        {
            _service = service;
            _mapper = mapper;
            _supplierService = supplierService;
        }

        //? SUPPLIER CONTRACT WEBPAGES DO NOT WORK TEST WITH BREAKPOINT THE CREATE AND UPDATE METHODS

        public IActionResult Index()
        {
            var suppliers = _supplierService.GetSuppliers();
            var suppliersContracts = _service.GetSupplierContracts();
            var supplierContractsDTO = new List<SupplierContractDTO>();
            foreach (var item in suppliersContracts)
            {
                if (item.State != EntityState.Deleted)
                {
                    supplierContractsDTO.Add(_mapper.FromSupplierContract(item, suppliers));
                }
            }
            return View(supplierContractsDTO);
        }

        public IActionResult CreateSupplierContract()
        {
            var suppliers = _supplierService.GetSuppliers();
            ViewBag.Suppliers = suppliers;
            SupplierContractDTO supplierContractDTO = new();
            return View(supplierContractDTO);
        }
        [HttpPost]
        public IActionResult CreateSupplierContract(SupplierContractDTO supplierContractDTO)
        {
            var suppliers = _supplierService.GetSuppliers();
            var supplierContract = _mapper.ToSupplierContract(supplierContractDTO, suppliers);
            var result = _service.CreateSupplierContract(supplierContract);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }
        public IActionResult UpdateSupplierContract(int id)
        {
            var suppliers = _supplierService.GetSuppliers();
            ViewBag.Suppliers = suppliers;
            var supplierContract = _service.GetById(id);
            var supplierContractDTO = _mapper.FromSupplierContract(supplierContract, suppliers);
            return View(supplierContractDTO);
        }
        [HttpPost]
        public IActionResult UpdateSupplierContract(SupplierContractDTO supplierContractDTO)
        {
            var suppliers = _supplierService.GetSuppliers();
            var supplierContract = _mapper.ToSupplierContract(supplierContractDTO, suppliers);
            var result = _service.UpdateSupplierContract(supplierContract);
            ViewBag.Suppliers = suppliers;
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSupplierContract(int id)
        {
            var result = _service.DeleteSupplierContract(id);
            TempData["Result"] = result;
            return RedirectToAction("Index");
        }
    }
}
