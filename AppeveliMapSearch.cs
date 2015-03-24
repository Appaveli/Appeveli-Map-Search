using Microsoft.Phone.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppeveliMapSearchTask
{
    class AppeveliMapSearch
    {
        public void SearchPlace(string search)
        {
            MapsTask mapsTask = new MapsTask();
            mapsTask.SearchTerm = search;
            mapsTask.ZoomLevel = 2;
            mapsTask.Show();
        }
    }
}
