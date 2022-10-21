using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPractice
{
	internal class Graph
	{
		//Attributes

		public List<Node> nodesList = new List<Node>();
		private List<Edge> edgesList = new List<Edge>();

		public int assignNodeData=0;

		//Methods
		public void insertNode(Node node)
		{
			nodesList.Add(node);
		}
		public void deleteNode(Node node)
		{
			if (node.data == null)
            {
				Console.WriteLine("--------Node already deleted-------");
				return;
            }
			nodesList.RemoveAt((int)node.data);
            //foreach (Edge edge in edgesList)
            //{
            //    if (edge.initalNode == node)
            //    {
            //        edge.initalNode = null;
            //        edge.finalNode = null;
            //        edge.weight = 0;
            //    }
            //    if (edge.finalNode == node)
            //    {
            //        edge.initalNode = null;
            //        edge.finalNode = null;
            //        edge.weight = 0;
            //    }
            //}
            //node.data = null;
        }
		public void insertEdge(Node initialNode,Node finalNode, int weight)
		{
			if (initialNode.data==finalNode.data)
			{
				Console.WriteLine("+++++Connecting a node with itself is forbitten.+++");
				return;
			}
			Edge edge = new Edge(initialNode,finalNode,weight);
			edgesList.Add(edge);
			finalNode.edgesList.Add(edge);
		}
		public void deleteEdge(Edge edge)
        {
			for (int i = 0; i<edgesList.Count;i++)
            {
                if (edgesList[i]==edge)
                {
					edgesList.RemoveAt(i);
				}
			}
        }
		public void printGraphConnections()
		{
			int zeroCounter = 0;
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
			for (int i = 0; i < nodesList.Count;i++)
			{
				Console.Write(nodesList[i].data+"| ");
				for(int j = 0; j < nodesList.Count; j++)
				{
					foreach(Edge edge in edgesList)
					{
						if (edge.initalNode.data==nodesList[i].data && edge.finalNode.data == nodesList[j].data)
						{
							Console.Write(1 + "  ");
							zeroCounter= zeroCounter+1;
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
	}
}
