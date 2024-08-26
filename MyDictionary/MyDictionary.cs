using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] arrayKey;
        V[] arrayValue;
        K[] tempArrayKey;
        V[] tempArrayValue;

        public MyDictionary()
        {
            arrayKey = new K[0];
            arrayValue = new V[0];
        }

        public void Add(K key, V value)
        {
            tempArrayKey = arrayKey;
            tempArrayValue = arrayValue;
            arrayKey = new K[arrayKey.Length + 1];
            arrayValue = new V[arrayKey.Length + 1];


            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                arrayKey[i] = tempArrayKey[i];
                arrayValue[i] = tempArrayValue[i];
            }
            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayKey.Length - 1] = value;

        }

        public int Count
        {
            get { return arrayKey.Length; }
        }

    }
}
