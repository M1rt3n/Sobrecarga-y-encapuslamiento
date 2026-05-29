using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_SmartTV
{
    public class SmartTV
    {
        private string marca { get; set; }
        private int pulgadas { get; set; }
        private bool encendido { get; set; }
        private int canal { get; set; }
        private int volumen { get; set; }
        private int maximo { get; set; }
        private bool premium { get; set; }

        public string _Marca
        {
            get => marca;
            set => marca = value;
        }
        public int _Pulgadas
        {
            get => pulgadas;
            set => pulgadas = value;
        }
        public bool _Encendido
        {
            get => encendido;
            set => encendido = value;
        }
        public int _CanalActual
        {
            get => canal;
            set => canal = value;
        }

        public int _Volumen
        {
            get => volumen;
            set => volumen = value;
        }
        public int _Máximo
        {
            get => maximo;
            set => maximo = value;
        }

        public bool _EsPremium
        {
            get => premium;
            set => premium = value;
        }
        public SmartTV(string _Marca, int _Pulgadas, bool _Encendido, int _CanalActual, int _Volumen, bool _EsPremium, int _Máximo)
        {
            this.marca = _Marca;
            this.pulgadas = _Pulgadas;
            this.encendido = _Encendido;
            this.canal = _CanalActual;
            this.volumen = _Volumen;
            this.maximo = _Máximo;
            this.premium = _EsPremium;
        }
        public void Power()
        {
            if (_Encendido == true)
            {
                _Encendido = false;
                Console.WriteLine("Equipo apagado");
            }
            else
            {
                _Encendido = true;
                Console.WriteLine("Equipo encendido");
            };

        }
        public void CambiarCanal()
        {
            if (_Encendido == true)
            {
                _CanalActual += 1;
                if (_CanalActual > _Máximo) 
                {
                    _CanalActual = 1;
                }
            }
            else
            {
                Console.WriteLine("El equipo no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void CambiarCanal(int value)
        {
            if (_Encendido == true)
            {
                _CanalActual = value;
            }
            else
            {
                Console.WriteLine("El equipo no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void RegularVolumen(bool subir)
        {
            if (_Encendido == true)
            {
                if (subir == true)
                {
                    _Volumen += 2;
                }
                else
                {
                    _Volumen -= 2;
                };
            };
        }

    }
}
