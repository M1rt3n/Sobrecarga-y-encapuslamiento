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
        private int _potencia { get; set; }
        private int _tiemposegundos { get; set; }
        private bool _puertac { get; set; }
        private bool _funciona { get; set; }

        public int Potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }
        public int TiempoSegundos
        {
            get => _tiemposegundos;
            set => _tiemposegundos = value;
        }
        public bool PuertaC
        {
            get => _puertac;
            set => _puertac = value;
        }
        public bool Funciona
        {
            get => _funciona;
            set => _funciona = value;
        }
        public Microondas(int _Potencia, int _TiempoSegundos, bool _PuertaC, bool _Funciona)
        {
            this._potencia = _Potencia;
            this._tiemposegundos = _TiempoSegundos;
            this._puertac = _PuertaC;
            this._funciona = _Funciona;
        }

        public void AgregarTiempo(int value)
        {
                TiempoSegundos += value;
            if (TiempoSegundos >= 3600)
            {
                Console.WriteLine("El tiempo asignado no puede superar los 3600 segundos, se asignará a ese tiempo");
                TiempoSegundos = 3600;
            }
        }
        public void AgregarTiempo()
        {
            TiempoSegundos += 30;
            if (TiempoSegundos >= 3600) 
            {
                Console.WriteLine("El tiempo asignado no puede superar los 3600 segundos, se asignará a ese tiempo");
                TiempoSegundos = 3600;
            }
        }
        public void Iniciar()
        {
            if (PuertaC == false)
            {
                Funciona = false;
                Console.WriteLine("La puerta no esta cerrada, por favor cierrela antes de ejecutar este comando");
            }
            else
            {
                if (TiempoSegundos == 0)
                {
                    {
                        Funciona = false;
                        Console.WriteLine("No hay segundos asignados, por favor asignelos antes de ejecutar este comando");
                    }
                }
                else
                {
                    Funciona = true;
                }
            }
        }
        public void Detener(int trigger)
        {
            if (Funciona == true)
            {
                if (trigger == 2)
                {
                    trigger = 0;
                    TiempoSegundos = 0;
                    Funciona = false;
                }
            }
            else 
            {
                Console.WriteLine("La el equipo está apagado, por favor enciendalo antes de ejecutar este comando");
            }
        }
        public void AbrirCerrarPuerta()
        {
            if (PuertaC == true)
            {
                PuertaC = false;
                Console.WriteLine("Puerta abierta");
            }
            else
            {
                PuertaC = true;
                Console.WriteLine("Puerta cerrada");
            }
            if (Funciona == true)
            {
                PuertaC = false;
            }
        }

    }
}
