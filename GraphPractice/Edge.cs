using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice
{
    internal class Edge
    {
        //Attributes
        public Node initalNode;
        public Node finalNode;
        public int weight;
        public Edge(Node initialNode, Node finalNode, int weight)
        {
            this.initalNode = initialNode;
            this.finalNode = finalNode;
            this.weight = weight;
        }
    }
}
