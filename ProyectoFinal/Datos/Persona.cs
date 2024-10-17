using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoFinal.Datos
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private string genero;
        private int edad;
        private int dni;

        public Persona(string nombre, string apellido, string genero, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido; 
            this.genero = genero;
            this.edad = edad;
            this.dni = dni;
        }
    }
}
