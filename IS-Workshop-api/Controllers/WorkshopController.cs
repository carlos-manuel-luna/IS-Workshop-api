using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop_api.Models;
using workshop_api.Services;

namespace workshop_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopController : ControllerBase
    {
        private readonly IWorkshopService _workshopService;

        public WorkshopController(IWorkshopService workshopService)
        {
            this._workshopService = workshopService;
        }

        [HttpGet]
        public ActionResult<List<WorkshopModel>> getWorkShops()
        {
            return _workshopService.getWorkshops();
        }
        [HttpGet("{workshopId}")]
        public ActionResult<WorkshopModel> getWorkShop(int workshopId)
        {
            return _workshopService.getWorkshop(workshopId);
        }
        [HttpPost]
        public ActionResult<WorkshopModel> createWorkShop(WorkshopModel workshopModel)
        {
            return _workshopService.createWorkshop(workshopModel);
        }
        [HttpDelete("{workshopId}")]
        public ActionResult<bool> deleteWorkShop(int workshopId)
        {
            return _workshopService.deleteWorkshop(workshopId);
        }
        [HttpPut("{workshopId}")]
        public ActionResult<WorkshopModel> editWorkShop(int workshopId,WorkshopModel workshop)
        {
            return _workshopService.editWorkShop(workshopId,workshop);
        }
        [HttpPut("{workshopId}/postponed")]
        public ActionResult<WorkshopModel> postponeWorkshop(int workshopId)
        {
            return _workshopService.changeStatusWorkshop(workshopId, "POSTPONED");
        }
        [HttpPut("{workshopId}/cancelled")]
        public ActionResult<WorkshopModel> cancelWorkshop (int workshopId)
        {
            return _workshopService.changeStatusWorkshop(workshopId, "CANCELLED");
        }
        [HttpPut("{workshopId}/scheduled")]
        public ActionResult<WorkshopModel> scheduleWorkshop(int workshopId)
        {
            return _workshopService.changeStatusWorkshop(workshopId, "SCHEDULED");
        }
    }
}
