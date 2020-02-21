using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_UI.Model
{
    public class clsBoton
    {

        private string _sound;
        private string _imagen;
        private int _id;


        public clsBoton()
        {
            _sound = "";
            _imagen = "";
            _id = 0;
        }

        public clsBoton(string sound, string imagen, int id)
        {
            _sound = sound;
            _imagen = imagen;
            _id = id;
        }

        public string Sound
        {
            get
            {
                return _sound;
            }
            set
            {
                _sound = value;
            }
        }

        public string Imagen
        {
            get
            {
                return _imagen;
            }
            set
            {
                _imagen = value;
            }
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

    }
}
