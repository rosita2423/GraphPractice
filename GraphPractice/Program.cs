// See https://aka.ms/new-console-template for more information
using GraphPractice;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Graph graph = new Graph();

        //Creating Nodes.
        Node n0 = new Node(graph);
        Node n1 = new Node(graph);
        Node n2 = new Node(graph);
        Node n3 = new Node(graph);
        Node n4 = new Node(graph);
        Node n5 = new Node(graph);
        Node n6 = new Node(graph);
        Node n7 = new Node(graph);
        Node n8 = new Node(graph);
        Node n9 = new Node(graph);
        Node n10 = new Node(graph);
        Node n11 = new Node(graph);

        //Creating Edges.
        Edge e1 = new Edge(n0, n1, 5);
        Edge e2 = new Edge(n0, n2, 7);
        Edge e3 = new Edge(n0, n3, 10);
        Edge e4 = new Edge(n2, n4, 2);
        Edge e5 = new Edge(n2, n5, 9);
        Edge e6 = new Edge(n3, n6, 13);
        Edge e7 = new Edge(n3, n7, 8);
        Edge e8 = new Edge(n3, n8, 9);
        Edge e9 = new Edge(n8, n9, 10);
        Edge e10 = new Edge(n9, n10, 11);
        Edge e11 = new Edge(n9,n11,20);

        //Adding nodes to the graph.
        graph.insertNode(n0);
        graph.insertNode(n1);
        graph.insertNode(n2);
        graph.insertNode(n3);
        graph.insertNode(n4);
        graph.insertNode(n5);
        graph.insertNode(n6);
        graph.insertNode(n7);
        graph.insertNode(n8);
        graph.insertNode(n9);

        //Adding edges to the graph.
        graph.insertEdge(e1);
        graph.insertEdge(e2);
        graph.insertEdge(e3);
        graph.insertEdge(e4);
        graph.insertEdge(e5);
        graph.insertEdge(e6);
        graph.insertEdge(e7);
        graph.insertEdge(e8);
        graph.insertEdge(e9);

        //Deleting nodes.
        //graph.deleteNode(n8);
        //graph.deleteNode(n4);
        //graph.deleteNode(n1);
        graph.deleteNode(n3);

        //Deleting edges.
        graph.deleteEdge(e1);
        //graph.deleteEdge(e8);

        //Print graph.
        graph.printGraphConnections();
        graph.printGraphWeights();
        graph.transverseGraphBFS(n0);
        Console.WriteLine();
        graph.transverseGraphDFS(n0);    
    }
}
