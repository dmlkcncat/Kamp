using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<T, Y>
    {
        T[] _keys;
        Y[] _values;
        T[] _tempKeys;
        Y[] _tempValues;

        public MyDictonary()
        {
            _keys = new T[0];
            _values = new Y[0];
        }

        public void Add(T key, Y value)
        {
            T[] _tempKeys = _keys;
            Y[] _tempValues = _values;

            _keys = new T[_keys.Length + 1];
            _values = new Y[_values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i];
            }

            _keys[_keys.Length -1 ] = key;

            for (int i = 0; i < _tempValues.Length; i++)
            {
                _values[i] = _tempValues[i];
            }

            _values[_values.Length - 1] = value;
        }
     
    }
}
