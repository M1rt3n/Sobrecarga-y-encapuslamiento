using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simulador_Microondas
{
    public class Microondas
    {
        private int potencia { get; set; }
        private int tiemposegundos { get; set; }
        private bool puertac { get; set; }
        private bool funciona { get; set; }

        public int _Potencia
        {
            get => potencia;
            set => potencia = value;
        }
        public int _TiempoSegundos
        {
            get => tiemposegundos;
            set => tiemposegundos = value;
        }
        public bool _PuertaC
        {
            get => puertac;
            set => puertac = value;
        }
        public bool _Funciona
        {
            get => funciona;
            set => funciona = value;
        }
        public Microondas(int _Potencia, int _TiempoSegundos, bool _PuertaC, bool _Funciona)
        {
            this.potencia = _Potencia;
            this.tiemposegundos = _TiempoSegundos;
            this.puertac = _PuertaC;
            this.funciona = _Funciona;
        }

        public void AgregarTiempo(int value)
        {
                _TiempoSegundos += value;
            if (_TiempoSegundos >= 3600)
            {
                Console.WriteLine("El tiempo asignado no puede superar los 3600 segundos, se asignará a ese tiempo");
                _TiempoSegundos = 3600;
            }
        }
        public void AgregarTiempo()
        {
            _TiempoSegundos += 30;
            if (_TiempoSegundos >= 3600) 
            {
                Console.WriteLine("El tiempo asignado no puede superar los 3600 segundos, se asignará a ese tiempo");
                _TiempoSegundos = 3600;
            }
        }
        public void Iniciar()
        {
            if (_PuertaC == false)
            {
                _Funciona = false;
                Console.WriteLine("La puerta no esta cerrada, por favor cierrela antes de ejecutar este comando");
            }
            else
            {
                if (_TiempoSegundos == 0)
                {
                    {
                        _Funciona = false;
                        Console.WriteLine("No hay segundos asignados, por favor asignelos antes de ejecutar este comando");
                    }
                }
                else
                {
                    _Funciona = true;
                }
            }
        }
        public void Detener(int trigger)
        {
            if (_Funciona == true)
            {
                if (trigger == 2)
                {
                    trigger = 0;
                    _TiempoSegundos = 0;
                    _Funciona = false;
                }
            }
            else 
            {
                Console.WriteLine("La el equipo está apagado, por favor enciendalo antes de ejecutar este comando");
            }
        }
        public void AbrirCerrarPuerta()
        {
            if (_PuertaC == true)
            {
                _PuertaC = false;
                Console.WriteLine("Puerta abierta");
            }
            else
            {
                _PuertaC = true;
                Console.WriteLine("Puerta cerrada");
            }
            if (_Funciona == true)
            {
                _PuertaC = false;
            }
        }

    }
}
