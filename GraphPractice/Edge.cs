using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice
{
    internal class Edge
    {
        //Attributes of edge
        private Nullable<bool> direction = null;
        private Node connectedNode1 = null;
        private Node connectedNode2 = null;

        //Constructors of edge, this one require only 2 nodes in order to create an edge with
        //both directions enabled.
        public Edge(Node firstNode,Node secondNode)
        {
            //Add the node to the list of connected nodes in each one of its respectives nodes.
            firstNode.aimingNodes.Add(secondNode);
            connectedNode1 = firstNode;

            secondNode.aimingNodes.Add(firstNode);
            connectedNode2 = secondNode;
        }
        //In order to make a connection edge with a specific direction, you should specify
        //what direction is (left or right).
        public Edge(Node firstNode, Node secondNode,string adress)
        {
            if(adress == "left")
            {
                firstNode.aimingNodes.Add(secondNode);
                connectedNode1 = firstNode;
            }
            else if(adress == "right")
            {
                secondNode.aimingNodes.Add(firstNode);
                connectedNode2 = secondNode;
            }
            else
            {
                Console.WriteLine("++++++ Error: You write the adress incorrectly. ++++++++");
            }
        }
    }
}
