using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice
{
    internal class Node
    {
        //Attributes
        public int data;
        public List<Edge> edgesList = new List<Edge>();
        public Node(Graph graph)
        {
            data = graph.assignNodeData;
            graph.assignNodeData++;
        }
    }
}
