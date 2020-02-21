using SimonCompadre_DAL.Lists;
using SimonCompadre_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_BL.Lists
{
    public class clsListadoPuntuacionesBL
    {

        public clsListadoPuntuacionesBL()
        {

        }

        public List<clsPuntuaciones> obtenerPuntuacionesBL()
        {
            List<clsPuntuaciones> scores = new List<clsPuntuaciones>();

            clsListadoPuntuaciones listadoPuntuaciones = new clsListadoPuntuaciones();

            scores = listadoPuntuaciones.obtenerPuntuaciones();

            return scores;
        }

    }
}
