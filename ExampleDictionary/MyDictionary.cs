﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDictionary
{
    class MyDictionary<tK, tV>
    {
        tK[] keys; 
        tV[] values;
        
        public MyDictionary()
        {
            keys = new tK[0];
            values = new tV[0];

        }
        public void Add(tK key, tV value)
        {
            tK[] tempKey = keys;
            tV[] tempValue = values;
            keys = new tK[keys.Length + 1];
            values = new tV[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public tK[] Keys
        {
            get { return keys; }
        }
        public tV[] Values
        {
            get { return values; }
        }
    }
}
