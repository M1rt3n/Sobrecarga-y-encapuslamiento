using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_de_SmartTV
{
    public class SmartTV
    {
        private string _marca { get; set; }
        private int _pulgadas { get; set; }
        private bool _encendido { get; set; }
        private int _canal { get; set; }
        private int _volumen { get; set; }
        private int _maximo { get; set; }
        private bool _premium { get; set; }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int Pulgadas
        {
            get { return _pulgadas; }
            set { _pulgadas = value; }
        }
        public bool Encendido
        {
            get { return _encendido; }
            set { _encendido = value; }
        }
        public int CanalActual
        {
            get { return _canal; }
            set { _canal = value; }
        }

        public int Volumen
        {
            get { return _volumen; }
            set { _volumen = value; }
        }
        public int Máximo
        {
            get { return _maximo; }
            set { _maximo = value; }
        }

        public bool EsPremium
        {
            get { return _premium; }
            set { _premium = value; }
        }
        public SmartTV(string marca, int pulgadas, bool encendido, int canalactual, int volumen, bool espremium, int máximo)
        {
            this.Marca = marca;
            this.Pulgadas = pulgadas;
            this.Encendido = encendido;
            this.CanalActual = canalactual;
            this.Volumen = volumen;
            this.Máximo = máximo;
            this.EsPremium = espremium;
        }
        public void Power()
        {
            if (Encendido == true)
            {
                Encendido = false;
                Console.WriteLine("Equipo apagado");
            }
            else
            {
                Encendido = true;
                Console.WriteLine("Equipo encendido");
            };

        }
        public void CambiarCanal()
        {
            if (Encendido == true)
            {
                CanalActual += 1;
                if (CanalActual > Máximo) 
                {
                    CanalActual = 1;
                }
            }
            else
            {
                Console.WriteLine("El equipo no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void CambiarCanal(int value)
        {
            if (Encendido == true)
            {
                CanalActual = value;
            }
            else
            {
                Console.WriteLine("El equipo no está encendido, por favor enciendalo antes de ejecutar este comando");
            };
        }
        public void RegularVolumen(bool subir)
        {
            if (Encendido == true)
            {
                if (subir == true)
                {
                    Volumen += 2;
                }
                else
                {
                    Volumen -= 2;
                };
            };
        }
    }
}
