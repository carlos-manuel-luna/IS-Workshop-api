using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop_api.Models;

namespace workshop_api.Services
{
    public class WorkshopService : IWorkshopService
    {
        Random random = new Random();
        private readonly IDataWorkshop _DataWorkshops;
        public WorkshopService(IDataWorkshop workshopsData)
        {
            this._DataWorkshops = workshopsData;
        }
        public WorkshopModel changeStatusWorkshop(int id, string NewStatus)
        {
            var workshopToEdit = _DataWorkshops.getWorkshop(id);
            if (workshopToEdit != null)
            {   
                workshopToEdit.status = NewStatus;
            }
            return workshopToEdit;   
        }

        public WorkshopModel createWorkshop(WorkshopModel NewWorkShop)
        {
            NewWorkShop.id = random.Next();
            _DataWorkshops.addWorkshop(NewWorkShop);
            return NewWorkShop;        
        }

        public WorkshopModel editWorkShop(int id, WorkshopModel workshop)
        {
            WorkshopModel result = null;
            if (id == workshop.id)
            { 
                var workShopToEdit = _DataWorkshops.getWorkshop(id);
                if (workShopToEdit != null)
                {
                    workShopToEdit.id = workshop.id;
                    workShopToEdit.name = workshop.name;
                    workShopToEdit.status = workshop.status;
                }
                result = workShopToEdit;
            }
            return result;
        }

        public WorkshopModel getWorkshop(int id)
        {
            var workshopResult = _DataWorkshops.getWorkshop(id);
            return workshopResult;
        }

        public List<WorkshopModel> getWorkshops()
        {
            return _DataWorkshops.getWorkshops();
        }

        bool IWorkshopService.deleteWorkshop(int id)
        {
            bool resultResponse = true;
            WorkshopModel result = _DataWorkshops.getWorkshop(id);
            if (result == null)
            {
                resultResponse = false;
            }
            _DataWorkshops.deleteWorkshop(id);
            return resultResponse;
        }
    }
}
