using System;
using System.Collections.Generic;
using System.Text;
using workshop_api.Models;

namespace Data
{
    public interface IDataWorkshop
    {
        void addWorkshop(WorkshopModel workshop);
        void deleteWorkshop(int id);
        List<WorkshopModel> getWorkshops();
        WorkshopModel getWorkshop(int id);
    }
}
