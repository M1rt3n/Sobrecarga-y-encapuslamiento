using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Batería
{
    public class Batería
    {
        private int porcentajecarga { get; set; }
        private int saludbateria { get; set; }
        private bool conectadocargador { get; set; }
        private bool modoahorrodeenergia { get; set; }

        public int _PorcentajeCarga
        {
            get => porcentajecarga;
            set => porcentajecarga = value;
        }
        public int _SaludBatería
        {
            get => saludbateria;
            set => saludbateria = value;
        }
        public bool _CargadorConectado
        {
            get => conectadocargador;
            set => conectadocargador = value;
        }
        public bool _AhorroEnergía
        {
            get => modoahorrodeenergia;
            set => modoahorrodeenergia = value;
        }

        public Batería(int _PorcentajeCarga, int _SaludBatería, bool _CargadorConectado, bool _AhorroEnergía)
        {
            this.porcentajecarga = _PorcentajeCarga;
            this.saludbateria = _SaludBatería;
            this.conectadocargador = _CargadorConectado;
            this.modoahorrodeenergia = _AhorroEnergía;
        }
        public void Alternar_Cargador()
        {
            if (_CargadorConectado == true)
            {
                _CargadorConectado = false;
                Console.WriteLine("Cargador conectado");
            }
            else
            {
                _CargadorConectado = true;
                Console.WriteLine("Cargador desconectado");
            };
        }
        public void Consumir_Energía(int Bat)
        {
            _PorcentajeCarga -= Bat;
            if (_AhorroEnergía == true)
            {
                Bat = Bat / 2;
            }
            if (_PorcentajeCarga < 0)
            {
                Console.WriteLine("El equipo ha sido completamente descargado");
                _PorcentajeCarga = 0;
            }
        }
        public void Consumir_Energía()
        {
            _PorcentajeCarga -= 1;
            if (_PorcentajeCarga < 0)
            {
                Console.WriteLine("El equipo se encuentra completamente descargado");
                _PorcentajeCarga = 0;
            }
        }
        public void Ciclo_Carga()
        {
            if (_CargadorConectado == true)
            {
                _PorcentajeCarga += 10;
                if (_PorcentajeCarga > _SaludBatería)
                {
                    Console.WriteLine("El equipo ya está cargado al 100% de su capacidad");
                    _PorcentajeCarga = _SaludBatería;
                    _SaludBatería -= 1;
                }
            }
            else
            {
                Console.WriteLine("El equipo debe estar conectado a un cargador para realizar esta función");
            }
        }
    }
}
