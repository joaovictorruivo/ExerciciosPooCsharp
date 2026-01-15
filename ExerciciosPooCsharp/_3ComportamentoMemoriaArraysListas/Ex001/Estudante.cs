using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex001
{
    internal class Estudante
    {
        public string Nome {  get; set; }
        public string Email { get; set; } 

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
