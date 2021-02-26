using System;
using System.Collections.Generic;
using System.Linq;
using workshop_api.Models;

namespace Data
{
    public class DataWorkshop : IDataWorkshop
    {
        private List<WorkshopModel> workshops = new List<WorkshopModel>();
        Random random = new Random();
        public DataWorkshop() {
            workshops.Add(new WorkshopModel(){
            id = 1,
                name = "Training Tx: Sesión 6 - IT",
                status = "SCHEDULED"
            });
            workshops.Add(new WorkshopModel(){
            id = 2,
                name = "Training Tx: Sesión 7 - Soft Skills - Comunicaciones Efectivas",
                status = "POSTPONED"
            });
            workshops.Add(new WorkshopModel(){
            id = 3,
                name = "Training Tx: Sesión 9 - SoftSkills and Rules",
                status = "CANCELLED"
            });
        }

        public void addWorkshop(WorkshopModel workshop)
        {
            workshops.Add(workshop);
        }

        public void deleteWorkshop(int id)
        {
            var workshopToDelete = workshops.SingleOrDefault(a => a.id == id);
            workshops.Remove(workshopToDelete);
        }

        public WorkshopModel getWorkshop(int id)
        {
            return workshops.SingleOrDefault(x => x.id == id);
        }

        public List<WorkshopModel> getWorkshops()
        {
            return workshops;
        }

    }
}
