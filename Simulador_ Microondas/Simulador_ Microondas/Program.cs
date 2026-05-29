using Simulador_Microondas;
internal class Program
{
    private static void Main(string[] args)
    {
        int OP = 0;
        int Pot = 1;
        int TiS = 0;
        bool Pue = false;
        bool Fun = false;
        int trigger = 0;
        int value = 0;
        Console.WriteLine("========================================");
        Console.WriteLine("   INGRESO DE DATOS - NUEVO Microondas");
        Console.WriteLine("========================================");
        do
        {
            Console.Write("¿Cual es su potencia? (Del 1 al 10): ");
            OP = Convert.ToInt32(Console.ReadLine());
            if (OP <= 1 || OP >= 10)
            {
                Console.WriteLine("Valor incapaz, por favor ingrese una opción válida");
            }
            else
            {
                Pot = OP;
            }
        } while (OP <= 1 || OP >=10);
        Microondas Microondas1 = new Microondas(Pot, TiS, Pue, Fun);
        Console.WriteLine("========================================");
        Console.WriteLine(" Procesando datos y creando objeto...");
        Console.WriteLine(" ¡Microondas inicializado con éxito!");
        Console.WriteLine(" Presione cualquier tecla para abrir el Control Remoto...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   En funcionamiento:[" + Microondas1._Funciona + "] | Tiempo en segundos: " + Microondas1._TiempoSegundos + "| La puerta está cerrada:[" + Microondas1._PuertaC + "]");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Seleccionar Tiempo");
            Console.WriteLine("[2] Agregar 30 segundos al tiempo");
            Console.WriteLine("[3] Iniciar");
            Console.WriteLine("[4] Detener");
            Console.WriteLine("[5] Abrir/Cerrar Puerta");
            Console.WriteLine("[0] Salir del simulador");
            Console.WriteLine("========================================");
            OP = Convert.ToInt32(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    Console.WriteLine("¿Cuanto tiempo se quiere agregar?");
                    value = Convert.ToInt32(Console.ReadLine());
                    Microondas1.AgregarTiempo(value);
                    Console.ReadKey();
                    break;
                case 2:
                    Microondas1.AgregarTiempo();
                    Console.ReadKey();
                    break;
                case 3:
                    Microondas1.Iniciar();
                    Console.ReadKey();
                    break;
                case 4:
                    trigger += 1;
                    Microondas1.Detener(trigger);
                    Console.ReadKey();
                    break;
                case 5:
                    Microondas1.AbrirCerrarPuerta();
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