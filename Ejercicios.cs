using System.Diagnostics.Tracing;

namespace evaluacion_diagnostica
{
    public static class Ejercicios
    {
        public static string ValidarPalindromo(string palabra)
        {
            palabra = palabra.ToLower();
            string palabraInvertida = "";
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInvertida += palabra[i];
            }
            return palabra.Equals(palabraInvertida) ? "La palabra es un palindromo" : "La palabra no es un palindromo";
        }
        public static string CalcularEdad(string fecha, string hora)
        {
            DateTime fechaNacimiento = Convert.ToDateTime(fecha + " " + hora + ":00");
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacimiento;
            int edad = diferencia.Days / 365;
            int horas = diferencia.Hours;
            int minutos = diferencia.Minutes;
            return $"Su edad es {edad} años, {horas} horas y {minutos} minutos";
        }
        public static string GenerarPassword()
        {
            char[] words = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
            char[] numbers = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
            char[] symbols = ['!', '#', '$', '%', '&','@', '_', '~'];
            string password = "";
            password += words[GetPosition(words.Length - 1)].ToString().ToUpper();
            password += words[GetPosition(words.Length - 1)].ToString();
            password += numbers[GetPosition(numbers.Length - 1)].ToString();
            password += numbers[GetPosition(numbers.Length - 1)].ToString();
            password += words[GetPosition(words.Length - 1)].ToString();
            password += words[GetPosition(words.Length - 1)].ToString();
            password += numbers[GetPosition(numbers.Length - 1)].ToString();
            password += symbols[GetPosition(symbols.Length - 1)].ToString();
            return $"La contraseña es {password}";
        }
        public static int GetPosition(int largo)
        {
            return Random.Shared.Next(0, largo);
        }
        public static string Ahorcado()
        {
            /*
            string[] palabras = { "hola", "mundo", "computador", "programacion", "casa", "perro", "gato", "raton", "teclado", "monitor" };
            string palabra = palabras[GetPosition(palabras.Length - 1)];
            string palabraOculta = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                palabraOculta += "_";
            }
            int intentos = 0;
            while (intentos < 5)
            {
                Console.WriteLine("Escriba una letra");
                char letra = Convert.ToChar(Console.ReadLine());
                if (palabra.Contains(letra))
                {
                    for (int i = 0; i < palabra.Length; i++)
                    {
                        if (palabra[i] == letra)
                        {
                           
                        }
                    }
                    Console.WriteLine($"La palabra es {palabraOculta}");
                    if (palabraOculta.Equals(palabra))
                    {
                        return "Ganaste";
                    }
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"La palabra es {palabraOculta}");
                    Console.WriteLine($"Te quedan {5 - intentos} intentos");
                }
                
            }
            return "Perdiste";
            */
            return "No implementado";
        }
        public static string Fibonacci(int numero)
        {
            int[] numbers = new int[numero];
            for (int i = 0; i < numero; i++)
            {
                if (i == 0 || i == 1)
                {
                    numbers[i] = i;
                }
                else
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
            }
            string serie = string.Join(", ", numbers);
            return $"La serie es {serie}";
        }
    }
}
