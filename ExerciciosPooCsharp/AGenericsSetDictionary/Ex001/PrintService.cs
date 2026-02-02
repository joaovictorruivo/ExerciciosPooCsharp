using System;
/*Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
1 a 10), e depois imprima esses números de forma organizada conforme
exemplo. Em seguida, informar qual foi o primeiro valor informado.

How many values? 3 Criar um serviço de impressão: 10
8
23
[10, 8, 23]
First: 10*/


namespace ExerciciosPooCsharp.AGenericsSetDictionary.Ex001
{
    internal class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if ( _count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for(int  i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if ( _count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

    }
}
