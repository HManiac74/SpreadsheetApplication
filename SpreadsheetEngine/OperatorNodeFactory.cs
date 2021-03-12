﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    /// <summary>
    /// Creates OperatorNodes.
    /// </summary>
    public class OperatorNodeFactory
    {
        /// <summary>
        /// CreateOperatorNode will return an OperatorNode.
        /// </summary>
        /// <param name="operatr">A string with the operator to create a node type of.</param>
        /// <returns></returns>
        public OperatorNode CreateOperatorNode(string operatr)
        {
            switch (operatr)
            {
                case "*": return new MultiplicationOperatorNode();
                case "/": return new DivisionOperatorNode();
                case "-": return new SubtractionOperatorNode();
                case "+": return new AdditionOperatorNode();
                default: return null;
            }
        }
    }
}
