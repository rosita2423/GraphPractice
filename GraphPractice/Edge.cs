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
            if (initialNode.data == finalNode.data)
            {
                Console.WriteLine("+++++Connecting a node with itself is forbitten.+++++");
                return;
            }
            //Assigning edge values.
            this.initalNode = initialNode;
            this.finalNode = finalNode;
            this.weight = weight;

            initalNode.children.Add(finalNode);
        }
    }
}
