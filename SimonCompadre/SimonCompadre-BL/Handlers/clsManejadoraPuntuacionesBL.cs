using SimonCompadre_DAL.Handlers;
using SimonCompadre_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_BL.Handlers
{
    public class clsManejadoraPuntuacionesBL
    {
        public clsManejadoraPuntuacionesBL()
        {

        }

        public int insertarPuntuacionBL(clsPuntuaciones puntuaciones)
        {

            int filas = 0;

            clsManejadoraPuntuaciones manejadoraPuntuaciones = new clsManejadoraPuntuaciones();

            filas = manejadoraPuntuaciones.insertarPuntuacion(puntuaciones);

            return filas;

        }

    }
}
