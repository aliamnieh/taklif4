using System;
using System.Collections.Generic;
using System.Text;

namespace mohit_masahat
{
    class Trapezium
    {
        private double Ertefa;
        private double Ghaede1;
        private double Ghaede2;
        public double masahat;
        public Trapezium(double ertefa,double ghaede1,double ghede2)
        {
            Ertefa = ertefa;
            Ghaede1 = ghaede1;
            Ghaede2 = ghede2;
            masahat = (ghaede1 + ghede2) * ertefa * 0.5;
        }
    }
}
