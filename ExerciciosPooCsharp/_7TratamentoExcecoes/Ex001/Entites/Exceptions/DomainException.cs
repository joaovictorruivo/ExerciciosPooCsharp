using System;

namespace ExerciciosPooCsharp._7TratamentoExcecoes.Ex001.Entites.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {   
        }
    }
}
