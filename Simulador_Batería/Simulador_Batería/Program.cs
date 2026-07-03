using Simulador_Batería;

internal class Program
{
    private static void Main(string[] args)
    {
        int OP = 0;
        int PoC = 99;
        int SaB = 100;
        bool CaC = false;
        bool MAE = false;
        int value = 0;
        string state = "Inactivo";
        Console.WriteLine("========================================");
        Console.WriteLine("   INGRESO DE DATOS - NUEVA BATERÍA     ");
        Console.WriteLine("========================================");
        Batería Batería1 = new Batería(PoC, SaB, CaC, MAE);
        Console.WriteLine("========================================");
        Console.WriteLine(" Procesando datos y creando objeto...");
        Console.WriteLine(" ¡invernadero inicializado con éxito!");
        Console.WriteLine(" Presione cualquier tecla para abrir el Control Remoto...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("  Actividad actual: "+ state +" | Ahorro de batería: " + Batería1.ModoAhorroEnergía + " | Estado de batería: " + Batería1.PorcentajeCarga + "% | Cargando: " + Batería1.CargadorConectado + "");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Conectar cargador");
            Console.WriteLine("[2] Descargar porcentaje");
            Console.WriteLine("[3] Dejar pasar el tiempo");
            Console.WriteLine("[4] Dejar cargar");
            Console.WriteLine("[0] Salir del simulador");
            Console.WriteLine("========================================");
            OP = Convert.ToInt32(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    Batería1.Alternar_Cargador();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Cuanta batería consumió la aplicación");
                    value = Convert.ToInt32(Console.ReadLine());
                    Batería1.Consumir_Energía(value);
                    if (Batería1.PorcentajeCarga < 20) 
                    {
                        Batería1.ModoAhorroEnergía = true;
                    }
                    state = "Usando Instagram";
                    Console.ReadKey();
                    break;
                case 3:
                    Batería1.Consumir_Energía();
                    if (Batería1.PorcentajeCarga < 20)
                    {
                        Batería1.ModoAhorroEnergía = true;
                    }
                    state = "Dejado en reposo";
                    Console.ReadKey();
                    break;
                case 4:
                    Batería1.Ciclo_Carga();
                    if (Batería1.PorcentajeCarga > 20)
                    {
                        Batería1.ModoAhorroEnergía = false;
                    }
                    Console.ReadKey();
                    break;
                case 0:
                    Console.WriteLine("Cerrando simulación...");
                    break;
            }
        } while (OP != 0);
        Console.WriteLine("Gracias por haber probado la simulación, vuelva pronto");

    }
}