using SimonCompadre_UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_UI.ViewModel
{
    public class clsJuegoVM
    {
        #region Propiedades publicas
        private clsBoton _botonSeleccionado;
        private ObservableCollection<clsBoton> _tablero;
        private List<clsBoton> _orden;
        #endregion

        #region
        public clsJuegoVM()
        {
            _tablero.Add(new clsBoton("hola", "verde", 1));
            _tablero.Add(new clsBoton("hola", "rojo", 2));
            _tablero.Add(new clsBoton("hola", "azul", 3));
            _tablero.Add(new clsBoton("hola", "amarillo", 4));
        }
        #endregion

        #region Propiedades publicas

        public clsBoton BotonSeleccionado
        {
            get
            {
                return _botonSeleccionado;
            }
            set
            {
                _botonSeleccionado = value;
            }
        }

        public ObservableCollection<clsBoton> Tablero
        {
            get
            {
                return _tablero;
            }
        }
        #endregion

        #region Metodos
        public void generarSiguiente()
        {
            Random btnSiguiente = new Random();

            int idBoton = btnSiguiente.Next(1, 7);
            //TODO sacar de un video el sonido para jugar
            switch (idBoton)
            {
                case 1:
                    _orden.Add(new clsBoton("sonidp", "Hola", 1));
                    break;
                case 2:
                    _orden.Add(new clsBoton("sonidp", "Hola", 2));
                    break;
                case 3:
                    _orden.Add(new clsBoton("sonidp", "Hola", 3));
                    break;
                case 4:
                    _orden.Add(new clsBoton("sonidp", "Hola", 4));
                    break;
            }

        }
        #endregion
    }
}
