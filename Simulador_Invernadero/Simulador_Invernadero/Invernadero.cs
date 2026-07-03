namespace Simulador_Invernadero
{
    public class Invernadero
    {
        private string _nsector { get; set; }
        private int _tactual { get; set; }
        private float _hsuelo { get; set; }
        private bool _sriegoactivo { get; set; }
        private bool _cactiva { get; set; }
        private string _tcultivo { get; set; }

        public string NombreSector
        {
            get { return _nsector; }
            set { _nsector = value; }
        }
        public int TemperaturaActual
        {
            get => _tactual;
            set => _tactual = value;
        }
        public float HumedadSuelo
        {
            get => _hsuelo;
            set => _hsuelo = value;
        }
        public bool SistemaRiego
        {
            get => _sriegoactivo;
            set => _sriegoactivo = value;
        }
        public bool CalefacciónActiva
        {
            get => _cactiva;
            set => _cactiva = value;
        }
        public string TipoCultivo
        {
            get => _tcultivo;
            set => _tcultivo = value;
        }


        public Invernadero(string nombresector, int temperaturaactual, float humedadsuelo, bool sistemariego, bool calefacciónactiva, string tipocultivo)
        {
            this.NombreSector = nombresector;
            this.TemperaturaActual = temperaturaactual;
            this.HumedadSuelo = humedadsuelo;
            this.SistemaRiego = sistemariego;
            this.CalefacciónActiva = calefacciónactiva;
            this.TipoCultivo = tipocultivo;
        }
        public void SimularClima(int Tem, int Hum)
        {
            int OldTem;
            float OldHum;
                OldTem = TemperaturaActual;
                TemperaturaActual = Tem;
                if(TemperaturaActual > 45)
                {
                    Console.WriteLine("La temperatura no puede ser superior a 45°, por favor introduzca otro valor");
                    TemperaturaActual = OldTem;
                }
                OldHum = HumedadSuelo;
                HumedadSuelo = Hum;
                if (HumedadSuelo > 100)
                {
                    Console.WriteLine("La humedad no puede ser mayor al 100%, por favor introduzca otro valor");
                    HumedadSuelo = OldHum;
                }
        }
        public void SimularClima()
        {
            HumedadSuelo -= 5;
            TemperaturaActual += 1;
        }
        public void ControlarClima()
        {
            if (NombreSector == "TROPICAL")
            {
                if (HumedadSuelo <= 60)
                {
                    HumedadSuelo = 60;
                }
                if (TemperaturaActual > 28 || TemperaturaActual < 20)
                {
                    TemperaturaActual = 24;
                }
            }
            if (NombreSector == "DESERTICO")
            {
                if (HumedadSuelo >= 20)
                {
                    HumedadSuelo = 20;
                }
                if (TemperaturaActual > 35 || TemperaturaActual < 25)
                {
                    TemperaturaActual = 30;
                }
            }

        }
    }
}
