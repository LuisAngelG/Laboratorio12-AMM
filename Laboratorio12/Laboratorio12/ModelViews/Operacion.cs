using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio12.ModelViews
{
    internal class Operacion: ViewModelBase
    {
        //NUMERO 1 QUE RECEPCIONA VALORES
        int numeroBase;

        public int NumeroBase
        {
            get { return numeroBase; }
            set
            {

                if (numeroBase != value)
                {
                    numeroBase = value;
                    OnPropertyChanged();
                }
            }
        }
        //NUMERO 2 QUE RECEPCIONA VALORES
        int numeroAltura;

        public int NumeroAltura
        {
            get { return numeroAltura; }
            set
            {

                if (numeroAltura != value)
                {
                    numeroAltura = value;
                    OnPropertyChanged();
                }
            }
        }
        //RESULTADO DE LA OPERACION AREA
        public ICommand Area { get; set; }

        int resultadoArea;

        public int ResultadoArea
        {
            get { return resultadoArea; }
            set
            {

                if (resultadoArea != value)
                {
                    resultadoArea = value;
                    OnPropertyChanged();
                }
            }
        }
        //RESULTADO DE LA OPERACION PERIMETRO
        public ICommand Perimetro { get; set; }
        
        int resultadoPerimetro;

        public int ResultadoPerimetro
        {
            get { return resultadoPerimetro; }
            set
            {

                if (resultadoPerimetro != value)
                {
                    resultadoPerimetro = value;
                    OnPropertyChanged();
                }
            }
        }

        public Operacion()
        {
            Area = new Command(() =>
            {
                ResultadoArea = NumeroAltura * NumeroBase;
            });

            Perimetro = new Command(() =>
            {
                ResultadoPerimetro = (2*NumeroAltura) + (2* NumeroBase);
            });
        }
    }
}
