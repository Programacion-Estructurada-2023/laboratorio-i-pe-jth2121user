using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declarando de variables de tipo texto, capturando su valor desde la consola.
            string? Departamento;
            string? Municipio;
            string? Ciudad;
            
            //Declarando de variables de tipo texto,  asignando su valor desde la declaración.
            string? Colonia = "La Caridad";
            string? Color_casa = "blanco";

            //Declaracion de variables de tipo enteras, asignando su valor desde consola
            int Años_vividos;
            int Edad;

            //Declarando de variables de tipo date time,  asignando su valor desde la declaración.
            DateTime Fecha_nacimiento = new DateTime(2002,03,21);
            DateTime Fecha_actual = DateTime.Now;  

             //Obtener los datos de la terminal
            Console.WriteLine("Ingrese el departamento donde vive: ");
            Departamento = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el municipio donde vive: ");
            Municipio= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese la ciudad donde vive: ");
            Ciudad= Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese cuantos años tiene de vivir en su residencia: ");
            Años_vividos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual: ");
            Edad= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Impresión de datos obtenidos en la terminal
            Console.WriteLine("********************************************************");
            Console.WriteLine("El depertamento de donde es: " + Departamento);
            Console.WriteLine("El municipo de donde es: " + Municipio);
            Console.WriteLine("La ciudad de donde es: " + Ciudad);
            Console.WriteLine("El colonia donde vive: " + Colonia);
            Console.WriteLine("El color de su casa es: " + Color_casa);
            Console.WriteLine("Años de vivir en su residencia actual: " + Años_vividos);
            Console.WriteLine("Edad actual: " + Edad);
            Console.WriteLine("Su fecha de nacimiento es: " + Fecha_nacimiento);
            Console.WriteLine("La fecha actual es: " + Fecha_actual);
            Console.WriteLine("********************************************************");
            Console.WriteLine();

            //Asignar Funciones
            //Función para comparar cadena
            bool cadena_Comparativa = Departamento == Municipio;

            //Función de concatenar texto
            string? cadena_Concatenada = Departamento + " " + Municipio;

            //Función Mayuscula
            string? Función_Mayuscula = Ciudad.ToUpper();
            
            //Función de limpiado de cadena
            string? Función_Limpiado = Colonia.Trim();

            //Función de longitud de cadena
            int longitudCadena1 = Colonia.Length;
            int longitudCadena2 = Color_casa.Length;

            //Función de fecha formateada
            string? fecha_Formateada = Fecha_actual.ToString("dd/mm/yyyy");

            //Función adicionar 2 semanas
            DateTime fecha_2semanas = Fecha_nacimiento.AddDays(14);

            //Función Comparar fechas
            bool fechas_iguales = Fecha_actual == Fecha_nacimiento;
            bool fechaActua1 = Fecha_actual < Fecha_nacimiento;
            bool fecha_nacimiento1 = Fecha_actual  > Fecha_nacimiento;

            //Impresión de valores de funciones
            Console.WriteLine("********************************************************");
            Console.WriteLine("Comparación de cadena: " + cadena_Comparativa);
            Console.WriteLine("Concatenado: " + cadena_Concatenada);
            Console.WriteLine("Función mayuscula: " + Función_Mayuscula);
            Console.WriteLine("Cadena original: \"" + Colonia + "\"");
            Console.WriteLine("Limpiado de Cadena: \"" + Función_Limpiado + "\"");
            Console.WriteLine("Funcion de longitud de cadena 1: " + longitudCadena1);
            Console.WriteLine("Funcion de longitud de cadena 2: " + longitudCadena2);
            Console.WriteLine("Fecha Formateada: " + fecha_Formateada);
            Console.WriteLine("Fecha de nacimiento con dos semanas agregadas: " + fecha_2semanas);
            Console.WriteLine("Las fechas iguales: " + fechas_iguales);
            Console.WriteLine("Fecha de nacimiento mayor a fecha actua: " + fechaActua1);
            Console.WriteLine("Fecha de nacimiento menor a fecha actual: " + fecha_nacimiento1);
            Console.WriteLine("********************************************************");

            //Auto_Evaluacion = 8 
        }
    }
}