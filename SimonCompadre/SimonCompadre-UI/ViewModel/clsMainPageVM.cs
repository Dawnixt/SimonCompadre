using SimonCompadre_UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCompadre_UI.ViewModel
{
    public class clsMainPageVM
    {
        #region Propiedades publicas
        private clsBoton _botonSeleccionado;
        private ObservableCollection<clsBoton> _tablero;
        private List<clsBoton> _orden;
        #endregion

        #region
        public clsMainPageVM()
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
        public void generarOrden()
        {
            Random btnSiguiente = new Random();
            //for (int i = 0; i < 12; i++)
            //{

            //    idBoton = btnSiguiente.Next(1, 7);

            //    switch (idCarta)
            //    {
            //        case 1:
            //            if(numero1 < 2)
            //            {
            //                cartas.Add(new clsCarta(1, "ms-appx:///Assets/Adorable.jpg"));
            //                numero1++;
            //            }
            //            break;
            //        case 2:
            //            if (numero2 < 2)
            //            {
            //                cartas.Add(new clsCarta(2, "ms-appx:///Assets/SakuWitch.png"));
            //                numero2++;
            //            }
            //            break;
            //        case 3:
            //            if (numero3 < 2)
            //            {
            //                cartas.Add(new clsCarta(3, "ms-appx:///Assets/KaminaJimaru.jpg"));
            //                numero3++;
            //            }
            //            break;
            //        case 4:
            //            if (numero4 < 2)
            //            {
            //                cartas.Add(new clsCarta(4, "ms-appx:///Assets/Mercy.jpg"));
            //                numero4++;
            //            }
            //            break;
            //        case 5:
            //            if (numero5 < 2)
            //            {
            //                cartas.Add(new clsCarta(5, "ms-appx:///Assets/SOXVA.jpg"));
            //                numero5++;
            //            }
            //            break;
            //        case 6:
            //            if (numero6 < 2)
            //            {
            //                cartas.Add(new clsCarta(6, "ms-appx:///Assets/ChaldeaPark.jpg"));
            //                numero6++;
            //            }
            //            break;
            //    }

            //}

        }
        #endregion

    }
}
