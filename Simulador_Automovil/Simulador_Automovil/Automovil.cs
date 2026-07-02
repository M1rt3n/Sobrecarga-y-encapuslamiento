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
        private int _velocidadActual { get; set; }
        private bool _motorEncendido { get; set; }
        private bool _cajaAutomatica { get; set; }
        private bool _modoCrucero { get; set; }

        public string Marca
        {
            get => _marca;
            set => _marca = value;
        }
        public int VelocidadActual
        {
            get => _velocidadActual;
            set => _velocidadActual = value;
        }
        public bool MotorEncendido
        {
            get => _motorEncendido;
            set => _motorEncendido = value;
        }
        public bool CajaAutomatica
        {
            get => _cajaAutomatica;
            set => _cajaAutomatica = value;
        }
        public bool ModoCrucero
        {
            get => _modoCrucero;
            set => _modoCrucero = value;
        }
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
                    VelocidadActual = 180;
                }
                else
                {
                    VelocidadActual = 220;
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