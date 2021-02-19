﻿using System;
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
        public WorkshopModel changeStatusWorkshop(string NewStatus)
        {
            throw new NotImplementedException();
        }

        public WorkshopModel createWorkshop(WorkshopModel NewWorkShop)
        {
            NewWorkShop.id = random.Next();
            workshops.Add(NewWorkShop);
            return NewWorkShop;        
        }
        public WorkshopModel deleteWorkshop(string id)
        {
            throw new NotImplementedException();
        }
        public WorkshopModel getWorkshop(string id)
        {
            throw new NotImplementedException();
        }
        public List<WorkshopModel> getWorkshops()
        {
            return workshops;
        }
        bool IWorkshopService.deleteWorkshop(string id)
        {
            throw new NotImplementedException();
        }
    }
}
