using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop_api.Models;

namespace workshop_api.Services
{
    public class WorkshopService : IWorkshopService
    {
        private List<WorkshopModel> workshops = new List<WorkshopModel>();
        Random random = new Random();
        public WorkshopService()
        {
            workshops.Add(new WorkshopModel()
            {       
                id = 1,
                name = "Training Tx: Sesión 6 - IT",
                status = "SCHEDULED" 
            });
            workshops.Add(new WorkshopModel()
            {
                id = 2,
                name = "Training Tx: Sesión 7 - Soft Skills - Comunicaciones Efectivas",
                status = "POSTPONED"
            });
            workshops.Add(new WorkshopModel()
            {
                id = 3,
                name = "Training Tx: Sesión 9 - SoftSkills and Rules",
                status = "CANCELLED"
            });
        }
        public WorkshopModel changeStatusWorkshop(int id, string NewStatus)
        {
            var workshopToEdit = workshops.SingleOrDefault(a => a.id == id);
            if (workshopToEdit != null)
            {   
                workshopToEdit.status = NewStatus;
                return workshopToEdit;   
            }
            return null;
        }

        public WorkshopModel createWorkshop(WorkshopModel NewWorkShop)
        {
            NewWorkShop.id = random.Next();
            workshops.Add(NewWorkShop);
            return NewWorkShop;        
        }

        public WorkshopModel editWorkShop(int id, WorkshopModel workshop)
        {
            if (id == workshop.id)
            { 
                var workShopToEdit = workshops.SingleOrDefault(a => a.id == id);
                if (workShopToEdit != null)
                {
                    workShopToEdit.id = workshop.id;
                    workShopToEdit.name = workshop.name;
                    workShopToEdit.status = workshop.status;
                }
                return workShopToEdit;
            }
            return null;
        }

        public WorkshopModel getWorkshop(int id)
        {
            var workshopResult = workshops.SingleOrDefault(a => a.id == id);
            if (workshopResult != null)
            {
                return workshopResult;
            }
            return null;
        }

        public List<WorkshopModel> getWorkshops()
        {
            return workshops;
        }

        bool IWorkshopService.deleteWorkshop(int id)
        {
            var workshopToDelete = workshops.SingleOrDefault(a => a.id == id);
            if (workshopToDelete == null)
            {
                return false;
            }
            workshops.Remove(workshopToDelete);
            return true;
        }
    }
}
