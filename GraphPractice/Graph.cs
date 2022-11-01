using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GraphPractice
{
	internal class Graph
	{
		//Attributes

		public List<Node> nodesList = new List<Node>();
		private List<Edge> edgesList = new List<Edge>();

		private int high = 1;

		public int assignNodeData=0;

		public int shortest = 0;

		//Methods
		public void insertNode(Node node)
		{
			//Adding the node into the list of nodes.
			foreach (Node nodes in nodesList)
            {
				if(node == nodes)
                {
					Console.WriteLine("++++Cannot insert the same node more than two times+++++");
					return;
                }
            }
			nodesList.Add(node);
		}
		public void deleteNode(Node node)
		{
			for (int i = 0; i < nodesList.Count; i++)
			{
				for (int k = 0; k < nodesList[i].children.Count; k++)
				{
					if (nodesList[i].children[k] == node)
					{
						nodesList[i].children.RemoveAt(k);
					}
				}
			}
			//Removing the node into the list of nodes.
			for (int i = 0; i < nodesList.Count; i++)
            {
				
				if (nodesList[i] == node)
                {
					for (int k = 0; k > node.children.Count; k++)
					{
						nodesList[i].children.RemoveAt(k);
                    }
					for (int k = 0; k<edgesList.Count ;k++)
					{
						if (edgesList[k].initalNode == node || edgesList[k].finalNode == node )
						{
							edgesList.RemoveAt(k);
						}
					}
					nodesList.RemoveAt(i);
					return;
                }
            }
			Console.WriteLine("++++Node cannot be erased because it was already deleted++++");
		}
		public void insertEdge(Edge edge)
		{
			//Adding the edge into the list of edges.
			edgesList.Add(edge);
		}
		public void deleteEdge(Edge edge)
        {
			for (int i = 0; i < nodesList.Count; i++)
			{
				if (edge.initalNode == nodesList[i])
				{
					for (int k = 0; k<nodesList[i].children.Count;k++)
					{
						if (edge.finalNode == nodesList[i].children[k])
						{
							nodesList[i].children.RemoveAt(k);
						}
					}
				}
			}
                //Remove into the list of edges the parameter edge inserted.
                for (int i = 0; i<edgesList.Count;i++)
            {
                if (edgesList[i]==edge)
                {
					edgesList.RemoveAt(i);
					return;
				}
			}
			Console.WriteLine("++++Edge cannot be erased because it was already deleted++++");
        }
		public void printGraphConnections()
		{
			int zeroCounter = 0;

			//Print first 2 lines.
			Console.WriteLine("----------Connections matrix---------");
			Console.Write("   ");
			foreach (Node node in nodesList)
			{
				Console.Write(node.data + "  ");
			}
			Console.WriteLine();
			Console.Write("  ");
			foreach (Node node in nodesList)
			{
				Console.Write("---");
			}
			Console.WriteLine();

			//Transversing all nodes.
			for (int i = 0; i < nodesList.Count;i++)
			{
				Console.Write(nodesList[i].data + "| ");

				//Checking edges at nodes position.
				for(int j = 0; j < nodesList.Count; j++)
				{
					foreach(Edge edge in edgesList)
					{
						if (edge.initalNode.data==nodesList[i].data && edge.finalNode.data == nodesList[j].data)
						{
							Console.Write(1 + "  ");
							zeroCounter = zeroCounter + 1;
						}
					}
                    if (zeroCounter <= 0)
                    {
						Console.Write(0 + "  ");
					}
                    else
                    {
						zeroCounter=zeroCounter-1;
                    }
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public void printGraphWeights()
		{
			int zeroCounter = 0;

			//Print first 2 lines.
			Console.WriteLine("----------Weights matrix---------");
			Console.Write("   ");
			foreach (Node node in nodesList)
			{
				Console.Write(node.data + "  ");
			}
			Console.WriteLine();
			Console.Write("  ");
			foreach (Node node in nodesList)
			{
				Console.Write("---");
			}
			Console.WriteLine();

			//Transversing all nodes and edges to print them.
			for (int i = 0; i < nodesList.Count; i++)
			{
				Console.Write(nodesList[i].data + "| ");
				for (int j = 0; j < nodesList.Count; j++)
				{
					foreach (Edge edge in edgesList)
					{
						if (edge.initalNode.data == nodesList[i].data&& edge.finalNode.data == nodesList[j].data)
						{
							Console.Write(edge.weight+"  ");
							zeroCounter = zeroCounter + 1;	
						}
					}
					if (zeroCounter <= 0)
					{
						Console.Write(0 + "  ");
					}
					else
					{
						zeroCounter = zeroCounter - 1;
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public void transverseGraphBFS(Node node)
		{
			Console.WriteLine(node.data);

			foreach (Node nodes in node.children)
			{
				high = high + 1;
				transverseGraphBFS(nodes);
				high = high - 1;
			}
		}
		public void transverseGraphDFS(Node node)
		{
			foreach (Node nodes in node.children)
			{
				high = high + 1;
				transverseGraphDFS(nodes);
				high = high - 1;
			}
            Console.WriteLine(node.data);
        }
		public void shortAlgorithm(Node initialNode, Node goal)
		{
			int[] shortestList = new int[7];
			int sum = 0;
			int path1 = 0;
			int path2 = 0;

			Node actualNode = new Node(this);
			while (goal != actualNode)
			{

			}
			foreach (Edge edges in edgesList)
			{
				if (edges.initalNode == initialNode)
				{
					foreach(Node nodes in initialNode.children)
					{

					}
                    if (path1 < edgesList[1].weight)
                    {
                        path1 = edgesList[1].weight;
                    }
                }
				foreach (Node nodes in nodesList)
				{
					if (edges.initalNode == nodes)
					{
                        if (path1 < edgesList[1].weight)
                        {
                            path1 = edgesList[1].weight;
                        }
                    }
                }
			}
		}
		public void shortAlgorithm(Node goal)
		{

		}
	}
}
