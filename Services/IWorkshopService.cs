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
        WorkshopModel getWorkshop(string id);
        bool changeStatusWorkshop(string NewStatus);
        bool deleteWorkshop(string id);
    }
}
