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
            DateOnly Fecha_nacimiento = new DateOnly(2002,03,21);
            DateTime Fecha_actual = DateTime.Now;   
        }
    }
}