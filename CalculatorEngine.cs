using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum oprator
{
    add,
    subtract,
    multiply,
    divide,
    none
}


namespace CalculatorGUI
{
    internal class CalculatorEngine
    {
        long operand1;
        long operand2;
        oprator oprator;
        public CalculatorEngine()
        {
            oprator = oprator.none;
            operand1 = 0;
            operand2 = 0;
        }

        public void SetOperand(long operand)
        {
            if (oprator == oprator.none)
            {
                operand1 = operand;
            }
            else
            {
                operand2 = operand;
            }
        }

        public void SetOperator(oprator oprator)
        {
            this.oprator = oprator;
        }

        public long GetResult()
        {
            if (oprator == oprator.none)
            {
                throw new InvalidOperationException("Operator not set");
            }
            long total = calculate(operand1, operand2, oprator);
            operand1 = total;
            oprator = oprator.none;
            operand2 = 0;
            return total;
        }

        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            oprator = oprator.none;
        }

        public long calculate(long operand1, long operand2, oprator oprator)
        {
            switch (oprator)
            {
                case oprator.add:
                    return checked(operand1 + operand2);
                case oprator.subtract:
                    return checked(operand1 - operand2);
                case oprator.multiply:
                    return checked(operand1 * operand2);
                case oprator.divide:
                    if (operand2 == 0 && operand1 != 0)
                    {
                        throw new DivideByZeroException();
                    }
                    return checked(operand1 / operand2);
                default:
                    throw new InvalidOperationException("Invalid operator");
            }
        }
    }
}
