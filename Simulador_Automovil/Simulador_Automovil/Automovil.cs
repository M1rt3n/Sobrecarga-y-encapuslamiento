using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_automovil
{
    public class Automovil
    {
        private string _marca { get; set; }
        private int _velocidadactual { get; set; }
        private bool _motorencendido { get; set; }
        private bool _cajaautomatica { get; set; }
        private bool _modocrucero { get; set; }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int VelocidadActual
        {
            get { return _velocidadactual; }
            set { _velocidadactual = value; }
        }
        public bool MotorEncendido
        {
            get { return _motorencendido; }
            set { _motorencendido = value; }
        }
        public bool CajaAutomatica
        {
            get { return _cajaautomatica; }
            set { _cajaautomatica = value; }
        }
        public bool ModoCrucero
        {
            get { return _modocrucero; }
            set { _modocrucero = value; }
        }
        public int Max;
        public Automovil(string marca, int velocidadActual, bool motorEncendido, bool cajaAutomatica, bool modoCrucero)
        {
            this.Marca = marca;
            this.VelocidadActual = velocidadActual;
            this.MotorEncendido = motorEncendido;
            this.CajaAutomatica = cajaAutomatica;
            this.ModoCrucero = modoCrucero;
        }
        public void EncenderApagar()
        {
            if (MotorEncendido == true)
            {
                MotorEncendido = false;
                Console.WriteLine("Motor apagado");
            }
            else
            {
                MotorEncendido = true;
                Console.WriteLine("Motor encendido");
            };

        }
        public void Acelerar()
        {
            if (MotorEncendido == true)
            {
                if (CajaAutomatica == false)
                {
                    VelocidadActual += 10;
                    if (VelocidadActual > 180)
                    {
                        VelocidadActual = 180;
                    }
                }
                else
                {
                    VelocidadActual = 220;
                    if (VelocidadActual > 220)
                    {
                        VelocidadActual = 220;
                    }
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Acelerar(int value)
        {
            if (MotorEncendido == true)
            {
                VelocidadActual += value;
                if (CajaAutomatica && VelocidadActual > 220)
                {
                    VelocidadActual = 220;
                }
                if (!CajaAutomatica && VelocidadActual > 180)
                {
                    VelocidadActual = 180;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Frenar()
        {
            if (MotorEncendido == true)
            {
                VelocidadActual = 0;
                if (ModoCrucero == true)
                {
                    Console.WriteLine("Modo crucero desactivado");
                    ModoCrucero = false;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Frenar(int value)
        {
            if (MotorEncendido == true)
            {
                VelocidadActual -= value;
                if (VelocidadActual < 0)
                {
                    VelocidadActual = 0;
                }
                Console.WriteLine("Modo crucero desactivado");
                if (ModoCrucero == true)
                {
                    ModoCrucero = false;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void ActivarMCrucero()
        {
            if (VelocidadActual > 60)
            {
                ModoCrucero = true;
                Console.WriteLine("Modo crucero activado");
            }
            else
            {
                Console.WriteLine("El modo crucero no se puede activar si la velocidad es menor a 60 km/h");
            };
        }

    }
}