using Simulador_de_SmartTV;

internal class Program
{
    private static void Main(string[] args)
    {
        int OP = 0;
        string op = "";
        string Mar = "";
        int Pul = 0;
        bool Enc = false;
        int Can = 10;
        int Vol = 8;
        bool Pre = false;
        int Max = 1;
        int value = 0;
        Console.WriteLine("========================================");
        Console.WriteLine("   INGRESO DE DATOS - NUEVO SmartTV");
        Console.WriteLine("========================================");
        Console.Write("Marca: ");
        Mar = Console.ReadLine();
        do
        {
            Console.Write("¿Es un SmartTV premium? (S/N): ");
            op = Console.ReadLine();
            if (op == "S" || op == "s")
            {
                Pre = true;
                Max = 500;
            }
            else
            {
                if (op == "N" || op == "n")
                {
                    Pre = false;
                    Max = 100;
                }
                else
                {
                    Console.WriteLine("Valor incorrecto, por favor ingrese una opción válida");
                }
            }
        } while (op != "S" && op != "s" && op != "N" && op != "n");
        SmartTV SmartTV1 = new SmartTV(Mar, Pul, Enc, Can, Vol, Pre, Max);
        Console.WriteLine("========================================");
        Console.WriteLine(" Procesando datos y creando objeto...");
        Console.WriteLine(" ¡SmartTV inicializado con éxito!");
        Console.WriteLine(" Presione cualquier tecla para abrir el Control Remoto...");
        Console.ReadKey();

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   Modelo equipo:" + SmartTV1._Marca + "   ");
            if (SmartTV1._Volumen <= 0) 
            {
                Console.WriteLine("   Estado del SmartTV:[" + SmartTV1._Encendido + "] | Canal: " + SmartTV1._CanalActual + "| Volumen:[MUTE]");
            }
            Console.WriteLine("   Estado del SmartTV:[" + SmartTV1._Encendido + "] | Canal: " + SmartTV1._CanalActual + "| Volumen:[" + SmartTV1._Volumen + "]");
            Console.WriteLine("========================================");
            Console.WriteLine("[1] Encender/Apagar");
            Console.WriteLine("[2] Cambiar a un canal específico");
            Console.WriteLine("[3] Subir de canal");
            Console.WriteLine("[4] Cambiar volúmen");
            Console.WriteLine("[0] Salir del simulador");
            Console.WriteLine("========================================");
            OP = Convert.ToInt32(Console.ReadLine());
            switch (OP)
            {
                case 1:
                    SmartTV1.Power();
                    Console.ReadKey();
                    break;
                case 2:
                    SmartTV1.CambiarCanal();
                    break;
                case 3:
                    Console.WriteLine("A que canal se quiere cambiar");
                    value = Convert.ToInt32(Console.ReadLine());
                    SmartTV1.CambiarCanal(value);
                    break;
                case 4:

                    do
                    {
                        Console.WriteLine("¿Se quiere aumentar el volúmen? (S/N)");
                        op = Console.ReadLine();
                        if (op == "S" || op == "s")
                        {
                            Pre = true;
                        }
                        else
                        {
                            if (op == "N" || op == "n")
                            {
                                Pre = false;
                            }
                            else
                            {
                                Console.WriteLine("Valor incorrecto, por favor ingrese una opción válida");
                            }
                        }
                    } while (op != "S" && op != "s" && op != "N" && op != "n");
                    SmartTV1.RegularVolumen(Pre);
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