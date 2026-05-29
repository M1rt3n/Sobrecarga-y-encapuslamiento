namespace Simulador_Invernadero
{
    public class Invernadero
    {
        private string nsector { get; set; }
        private int tactual { get; set; }
        private float hsuelo { get; set; }
        private bool sriegoactivo { get; set; }
        private bool cactiva { get; set; }
        private string tcultivo { get; set; }

        public string _NombreSector
        {
            get => nsector;
            set => nsector = value;
        }
        public int _TemperaturaActual
        {
            get => tactual;
            set => tactual = value;
        }
        public float _HumedadSuelo
        {
            get => hsuelo;
            set => hsuelo = value;
        }
        public bool _SistemaRiego
        {
            get => sriegoactivo;
            set => sriegoactivo = value;
        }
        public bool _CalefacciónActiva
        {
            get => cactiva;
            set => cactiva = value;
        }
        public string _TipoCultivo
        {
            get => tcultivo;
            set => tcultivo = value;
        }


        public Invernadero(string _NombreSector, int _TemperaturaActual, float _HumedadSuelo, bool _SistemaRiego, bool _CalefacciónActiva, string _TipoCultivo)
        {
            this.nsector = _NombreSector;
            this.tactual = _TemperaturaActual;
            this.hsuelo = _HumedadSuelo;
            this.sriegoactivo =_SistemaRiego;
            this.cactiva = _CalefacciónActiva;
            this.tcultivo = _TipoCultivo;
        }
        public void SimularClima(int Tem, int Hum)
        {
            int OldTem;
            float OldHum;
                OldTem = _TemperaturaActual;
                _TemperaturaActual = Tem;
                if(_TemperaturaActual > 45)
                {
                    Console.WriteLine("La temperatura no puede ser superior a 45°, por favor introduzca otro valor");
                    _TemperaturaActual = OldTem;
                }
                OldHum = _HumedadSuelo;
                _HumedadSuelo = Hum;
                if (_HumedadSuelo > 100)
                {
                    Console.WriteLine("La humedad no puede ser mayor al 100%, por favor introduzca otro valor");
                    _HumedadSuelo = OldHum;
                }
        }
        public void SimularClima()
        {
            _HumedadSuelo -= 5;
            _TemperaturaActual += 1;
        }
        public void ControlarClima()
        {
            if (_NombreSector == "TROPICAL")
            {
                if (_HumedadSuelo <= 60)
                {
                    _HumedadSuelo = 60;
                }
                if (_TemperaturaActual > 28 || _TemperaturaActual < 20)
                {
                    _TemperaturaActual = 24;
                }
            }
            if (_NombreSector == "DESERTICO")
            {
                if (_HumedadSuelo >= 20)
                {
                    _HumedadSuelo = 20;
                }
                if (_TemperaturaActual > 35 || _TemperaturaActual < 25)
                {
                    _TemperaturaActual = 30;
                }
            }

        }
    }
}
