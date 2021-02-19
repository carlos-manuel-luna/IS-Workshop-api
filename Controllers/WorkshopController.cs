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
        private readonly IWorkshopService workshopService;

        public WorkshopController(IWorkshopService workshopService)
        {
            this.workshopService = workshopService;
        }

        [HttpGet]
        public ActionResult<List<WorkshopModel>> getWorkShops()
        {
            return workshopService.getWorkshops();
        }

        [HttpPost]
        public ActionResult<WorkshopModel> createWorkShop(WorkshopModel workshopModel)
        {
            return workshopService.createWorkshop(workshopModel);
        }

        [HttpDelete("{workshopId}")]
        public ActionResult<bool> deleteWorkShop(int workshopId)
        {
            return workshopService.deleteWorkshop(workshopId);
        }
        [HttpPut("{workshopId}")]
        public ActionResult<WorkshopModel> editWorkShop(int workshopId,WorkshopModel workshop)
        {
            return workshopService.editWorkShop(workshopId,workshop);
        }
    }
}
