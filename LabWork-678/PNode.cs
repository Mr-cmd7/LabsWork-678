﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_678
{
    public class PNode<T>
    {
        public T Value { get; set; }
        public PNode<T>? Next { get; set; }
        public PNode<T>? Previous { get; set; }

        public PNode(T value)
        {
            Value = value;
        }
    }
}
