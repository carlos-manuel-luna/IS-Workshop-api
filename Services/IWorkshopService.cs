using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workshop_api.Models;

namespace workshop_api.Services
{
    public interface IWorkshopService
    {
        List<WorkshopModel> getWorkshops();
        WorkshopModel getWorkshop(int id);
        WorkshopModel editWorkShop(int id, WorkshopModel workshop);
        WorkshopModel changeStatusWorkshop(int id, string NewStatus);
        WorkshopModel createWorkshop(WorkshopModel NewStatus);
        bool deleteWorkshop(int id);
    }
}
