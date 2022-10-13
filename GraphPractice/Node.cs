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
        private Nullable<int> data = null;
        public List<Node> aimingNodes = new List<Node>();

        //Constructor to insert as obligatory the data of the node.
        public Node(int dataParameter)
        {
            data = dataParameter;
        }

        //Methods
        public void Delete()
        {
            for(int i = 0; i < aimingNodes.Count; i++)
            {
                if(aimingNodes[i] == this)
                {
                    aimingNodes.RemoveAt(i);
                }
            }
            this.data = null;
        }
    }
}
