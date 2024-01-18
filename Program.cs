namespace evaluacion_diagnostica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bienvenido a mi evaluacion diagnostica");
                Console.WriteLine("1. Validación de Palindromos");
                Console.WriteLine("2. Calculadora de Edad");
                Console.WriteLine("3. Generador de contraseñas");
                Console.WriteLine("4. Ahorcado");
                Console.WriteLine("5. Fibonacci");
                Console.WriteLine("6. Salir del programa");
                Console.WriteLine("Escriba el numero del ejercicio al que desee entrar:");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Escriba la palabra que desea validar:");
                            string palabra = Console.ReadLine() ?? "";
                            string resultado = Ejercicios.ValidarPalindromo(palabra);
                            Console.WriteLine(resultado);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        { 
                        Console.WriteLine("Escriba su fecha de nacimiento en formato dd/mm/aaaa:");
                        string fecha = Console.ReadLine() ?? "";
                        Console.WriteLine("Escriba la hora de su nacimiento en formato hh:mm");
                        string hora = Console.ReadLine() ?? "";
                        Console.Clear();
                        string resultado = Ejercicios.CalcularEdad(fecha, hora);
                        Console.WriteLine(resultado);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                        }
                    case 3:
                        {
                            string resultado = Ejercicios.GenerarPassword();
                            Console.WriteLine(resultado);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    
                    case 4:
                        {
                            string resultado = Ejercicios.Ahorcado();
                            Console.WriteLine(resultado);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        { 
                            Console.WriteLine("Escriba el numero de la serie de fibonacci que desea ver:");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            string resultado = Ejercicios.Fibonacci(numero);
                            Console.WriteLine(resultado);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}
