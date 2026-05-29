using Simulador_automovil;

internal class Program
{
    private static void Main(string[] args)
    {
        int OP = 0;
        string op = "";
        string Mar = "";
        int Vel = 0;
        bool Enc = false;
        bool Caj = true;
        bool Cru = false;
        int value = 0;
        Console.WriteLine("========================================");
        Console.WriteLine("   INGRESO DE DATOS - NUEVO AUTOMOVIL");
        Console.WriteLine("========================================");
        Console.Write("Marca: ");
        Mar = Console.ReadLine();
        do {
            Console.Write("¿Es un automovil de caja automática? (S/N): ");
            op = Console.ReadLine();
            if (op == "S" || op == "s")
            {
                Caj = true;
            }
            else
            {
                if (op == "N" || op == "n")
                {
                    Caj = false;
                }
                else
                {
                    Console.WriteLine("Valor incorrecto, por favor ingrese una opción válida");
                }
            }
        } while (op != "S" && op != "s" && op != "N" && op != "n");
        Automovil Auto1 = new Automovil(Mar,Vel,Enc,Caj,Cru);
        Console.WriteLine("========================================");
        Console.WriteLine(" Procesando datos y creando objeto...");
        Console.WriteLine(" ¡Automovil inicializado con éxito!");
        Console.WriteLine(" Presione cualquier tecla para abrir el Control Remoto...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   Modelo equipo:" + Auto1._Marca + "   ");
            Console.WriteLine("   Estado del motor:[" + Auto1._MotorEncendido + "] | Velocidad: " + Auto1._VelocidadActual + "km/h | Modo crucero:[" + Auto1._ModoCrucero + "]");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Encender/Apagar motor");
            Console.WriteLine("[2] Acelerar al máximo");
            Console.WriteLine("[3] Aumentar velocidad");
            Console.WriteLine("[4] Frenar en seco");
            Console.WriteLine("[5] Disminuir velocidad");
            Console.WriteLine("[6] Activar modo crucero");
            Console.WriteLine("[0] Salir del simulador");
            Console.WriteLine("========================================");
            OP = Convert.ToInt32(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    Auto1.EncenderApagar();
                    Console.ReadKey();
                    break;
                case 2:
                    Auto1.Acelerar();
                    break;
                case 3:
                    Console.WriteLine("En cuanto aumentar la velocidad actual (en km/h)");
                    value = Convert.ToInt32(Console.ReadLine());
                    Auto1.Acelerar(value);
                    break;
                case 4:
                    Auto1.Frenar();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("En cuanto disminuir la velocidad actual (en km/h)");
                    value = Convert.ToInt32(Console.ReadLine());
                    Auto1.Frenar(value);
                    Console.ReadKey();
                    break;
                case 6:
                    Auto1.ActivarMCrucero();
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