﻿using System;

namespace BOOPM3_04_02
{
    class Program
    {
        public class Baseclass
        {
            public int X;
            public Baseclass() { }
            public Baseclass(int x) { this.X = x; }
        }
        public class Subclass : Baseclass
        {
            public new int X;
            public int BaseX { get => base.X; }
            public Subclass(int x) : base(x) { X = 2 * x; }
        }
        static void Main(string[] args)
        {
            var s1 = new Subclass(123);
            Console.WriteLine(s1.X); // 246
            Console.WriteLine(s1.BaseX); // 123
        }
    }
}
