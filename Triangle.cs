using System;
using System.Collections.Generic;
using System.Text;

namespace mohit_masahat
{
    class Triangle
    {
        private double Ghaede;
        private double Ertefa;
        //public double mohit;
        public double masahat;
        public Triangle(double ghaede,double ertefa)
        {
            Ghaede = ghaede;
            Ertefa = ertefa;
            masahat = (ghaede * ertefa) * 0.5;
        }
    }
}
