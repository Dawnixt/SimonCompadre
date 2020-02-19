using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_Entities
{
    public class clsPuntuaciones
    {
        private int _id;
        private string _nombreJugador;
        private string _puntuacion;

        public clsPuntuaciones()
        {
            _id = 0;
            _nombreJugador = "";
            _puntuacion = "";

        }

        public clsPuntuaciones(string nombre, string puntuacion, int id)
        {
            _id = id;
            _nombreJugador = nombre;
            _puntuacion = puntuacion;

        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string NombreJugador
        {
            get
            {
                return _nombreJugador;
            }
            set
            {
                _nombreJugador = value;
            }
        }

        public string Puntuacion
        {
            get
            {
                return _puntuacion;
            }
            set
            {
                _puntuacion = value;
            }
        }

    }
}
