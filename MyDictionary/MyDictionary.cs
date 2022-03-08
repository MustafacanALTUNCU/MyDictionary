using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T,U>
    {
        T[] _array;
        T[] tempArray;
        U[] _array1;
        U[] tempArray1;
       

        public MyDictionary()
        {
            
            _array = new T[0];
            _array1 = new U[0];
        }

        public void Add(T key, U value) { 
            bool varmi = _array.Contains(key);
            if (varmi)
            {
                Console.WriteLine("Zaten eklendi");
            }
            else
            {

                tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    _array[i] = tempArray[i];

                }
                _array[_array.Length - 1] = key;
                tempArray1 = _array1;
                _array1 = new U[_array1.Length + 1];
                for (int i = 0; i < tempArray1.Length; i++)
                {
                    _array1[i] = tempArray1[i];
                }
                _array1[_array1.Length - 1] = value;
            }
            
            
        }
        public int Count { get { return _array.Length; } }
        public int Count1 { get { return _array1.Length; } }

        public void Yazdir()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(Convert.ToString(_array[i]) + " " + _array1[i]);

            }
        }
        


    }
}
