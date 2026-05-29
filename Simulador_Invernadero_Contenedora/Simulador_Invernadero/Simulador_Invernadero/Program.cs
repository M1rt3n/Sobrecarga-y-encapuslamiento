
using Simulador_Invernadero;

internal class Program
{
    private static void Main(string[] args)
    {
        int OP = 0;
        string op = "";
        string NoS = "";
        int TeA = 12;
        int Hus = 50;
        bool SRA = false;
        bool CaA = false;
        string TiC = "";
        int value = 0;
        int value2 = 0;
        Console.WriteLine("========================================");
        Console.WriteLine("   INGRESO DE DATOS - NUEVO Invernadero");
        Console.WriteLine("========================================");
        do
        {
            Console.WriteLine("Introduzca el nombre del tipo de sector (DESERTICO/TROPICAL)");
            NoS=Console.ReadLine();
            if (NoS == "TROPICAL" || NoS == "DESERTICO")
            {
                Console.WriteLine("Tipo de sector aceptado");
            }
            else 
            {
                Console.WriteLine("Tipo de sector no disponible, por favor introduzca otro tipo");
            }
        } while (NoS != "TROPICAL" && NoS != "DESERTICO");
        Invernadero Invernadero1 = new Invernadero(NoS, TeA, Hus, SRA, CaA, TiC);
        Console.WriteLine("========================================");
        Console.WriteLine(" Procesando datos y creando objeto...");
        Console.WriteLine(" ¡invernadero inicializado con éxito!");
        Console.WriteLine(" Presione cualquier tecla para abrir el Control Remoto...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    Temperatura: " + Invernadero1._TemperaturaActual + "| Humedad:[" + Invernadero1._HumedadSuelo + "]");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Establecer Temperatura y Humedad");
            Console.WriteLine("[2] Dejar pasar el tiempo");
            Console.WriteLine("[3] Gestión automática");
            Console.WriteLine("[0] Salir del simulador");
            Console.WriteLine("========================================");
            OP = Convert.ToInt32(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    Console.WriteLine("Temperatura");
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Humedad");
                    value2 = Convert.ToInt32(Console.ReadLine());
                    Invernadero1.SimularClima(value,value2);
                    Console.ReadKey();
                    break;
                case 2:
                    Invernadero1.SimularClima();
                    break;
                case 3:
                    Invernadero1.ControlarClima();
                    break;
                case 0:
                    Console.WriteLine("Cerrando simulación...");
                    break;
            }
        } while (OP != 0);
        Console.WriteLine("Gracias por haber probado la simulación, vuelva pronto");

    }
}