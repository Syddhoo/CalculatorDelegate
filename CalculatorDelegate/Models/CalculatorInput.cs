using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorDelegate.Models
{
    public class CalculatorInput
    {
        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }

        public string Operation { get; set; } = string.Empty;
    }
}
