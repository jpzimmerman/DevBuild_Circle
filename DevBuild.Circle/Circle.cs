using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Circle
{
    class Circle
    {
        private double radius;

        public Circle(double _circleRadius) {
            radius = _circleRadius;
        }

        public double Radius {
            get { return radius; }
            set { radius = value; }
        }


        public double CalculateCircumference() {
            return (2 * Math.PI * Radius);
        }

        public string CalculateFormattedCircumference() {
            return FormatNumber(CalculateCircumference()) + " units";
        }

        public double CalculateArea() {
            return (Math.PI * Math.Pow(Radius, 2));
        }

        public string CalculateFormattedArea() {
            return FormatNumber(CalculateArea()) + " square units";
        }

        private string FormatNumber(double x) {
            return Math.Round(x, 2).ToString();
        }
    }
}
