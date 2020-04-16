using System;
using System.Collections.Generic;
using System.Text;
using ExerciseShapes.Entities.Enums;

namespace ExerciseShapes.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
