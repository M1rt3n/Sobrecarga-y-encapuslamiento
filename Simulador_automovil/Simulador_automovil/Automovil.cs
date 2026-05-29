using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_automovil
{
    public class Automovil
    {
        private string marca { get; set; }
        private int velocidadActual { get; set; }
        private bool motorEncendido { get; set; }
        private bool cajaAutomatica { get; set; }
        private bool modoCrucero { get; set; }

        public string _Marca
        {
            get => marca;
            set => marca = value;
        }
        public int _VelocidadActual
        {
            get => velocidadActual;
            set => velocidadActual = value;
        }
        public bool _MotorEncendido
        {
            get => motorEncendido;
            set => motorEncendido = value;
        }
        public bool _CajaAutomatica
        {
            get => cajaAutomatica;
            set => cajaAutomatica = value;
        }
        public bool _ModoCrucero
        {
            get => modoCrucero;
            set => modoCrucero = value;
        }
        public Automovil(string _Marca, int _VelocidadActual, bool _MotorEncendido, bool _CajaAutomatica, bool _ModoCrucero)
        {
            this.marca = _Marca;
            this.velocidadActual = _VelocidadActual;
            this.motorEncendido = _MotorEncendido;
            this.cajaAutomatica = _CajaAutomatica;
            this.modoCrucero = _ModoCrucero;
        }
        public void EncenderApagar()
        {
            if (_MotorEncendido == true)
            {
                _MotorEncendido = false;
                Console.WriteLine("Motor apagado");
            }
            else
            {
                _MotorEncendido = true;
                Console.WriteLine("Motor encendido");
            };

        }
        public void Acelerar()
        {
            if (_MotorEncendido == true)
            {
                if (_CajaAutomatica == false) 
                {
                    _VelocidadActual = 180;
                }
                else 
                {
                    _VelocidadActual = 220;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Acelerar(int value)
        {
            if (_MotorEncendido == true)
            {
                _VelocidadActual += value;
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Frenar()
        {
            if (_MotorEncendido == true)
            {
                _VelocidadActual = 0;
                if (_ModoCrucero == true)
                {
                    Console.WriteLine("Modo crucero desactivado");
                    _ModoCrucero = false;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void Frenar(int value)
        {
            if (_MotorEncendido == true)
            {
                _VelocidadActual -= value;
                Console.WriteLine("Modo crucero desactivado");
                if (_ModoCrucero == true)
                {
                    _ModoCrucero = false;
                }
            }
            else
            {
                Console.WriteLine("El motor no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void ActivarMCrucero()
        {
            if (_VelocidadActual > 60)
            {
                _ModoCrucero = true;
                Console.WriteLine("Modo crucero activado");
            }
            else
            {
                Console.WriteLine("El modo crucero no se puede activar si la velocidad es menor a 60 km/h");
            };
        }

    }
}
