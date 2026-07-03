using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Batería
{
    public class Batería
    {
        private int _porcentajecarga { get; set; }
        private int _saludbateria { get; set; }
        private bool _cargadorconectado { get; set; }
        private bool _modoahorrodeenergia { get; set; }

        public int PorcentajeCarga
        {
            get { return _porcentajecarga; }
            set { _porcentajecarga = value; }
        }
        public int SaludBatería
        {
            get { return _saludbateria; }
            set { _saludbateria = value; }
        }
        public bool CargadorConectado
        {
            get { return _cargadorconectado; }
            set { _cargadorconectado = value; }
        }
        public bool ModoAhorroEnergía
        {
            get { return _modoahorrodeenergia;}
            set { _modoahorrodeenergia = value; }
        }

        public Batería(int porcentajecarga, int saludbatería, bool cargadorconectado, bool modoahorroenergía)
        {
            this.PorcentajeCarga = _porcentajecarga;
            this.SaludBatería = _saludbateria;
            this.CargadorConectado = _cargadorconectado;
            this.ModoAhorroEnergía = _modoahorrodeenergia;
        }
        public void Alternar_Cargador()
        {
            if (CargadorConectado == true)
            {
                CargadorConectado = false;
                Console.WriteLine("Cargador conectado");
            }
            else
            {
                CargadorConectado = true;
                Console.WriteLine("Cargador desconectado");
            };
        }
        public void Consumir_Energía(int Bat)
        {
            PorcentajeCarga -= Bat;
            if (ModoAhorroEnergía == true)
            {
                Bat = Bat / 2;
            }
            if (PorcentajeCarga < 0)
            {
                Console.WriteLine("El equipo ha sido completamente descargado");
                PorcentajeCarga = 0;
            }
        }
        public void Consumir_Energía()
        {
            PorcentajeCarga -= 1;
            if (PorcentajeCarga < 0)
            {
                Console.WriteLine("El equipo se encuentra completamente descargado");
                PorcentajeCarga = 0;
            }
        }
        public void Ciclo_Carga()
        {
            if (CargadorConectado == true)
            {
                PorcentajeCarga += 10;
                if (PorcentajeCarga > SaludBatería)
                {
                    Console.WriteLine("El equipo ya está cargado al 100% de su capacidad");
                    PorcentajeCarga = SaludBatería;
                    SaludBatería -= 1;
                }
            }
            else
            {
                Console.WriteLine("El equipo debe estar conectado a un cargador para realizar esta función");
            }
        }
    }
}
