// See https://aka.ms/new-console-template for more information
using GraphPractice;

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

        //Creating Edges.
        Edge e1 = new Edge(n2,n3,5);
        Edge e2 = new Edge(n3,n0,7);
        Edge e3 = new Edge(n6,n4,10);
        Edge e4 = new Edge(n6,n1,2);
        Edge e5 = new Edge(n1,n5,9);
        Edge e6 = new Edge(n5,n2,13);
        Edge e7 = new Edge(n2,n5,8);
        Edge e8 = new Edge(n6,n0,9);
        Edge e9 = new Edge(n6,n3,10);

        //Adding nodes to the graph.
        graph.insertNode(n0);
        graph.insertNode(n1);
        graph.insertNode(n2);
        graph.insertNode(n3);
        graph.insertNode(n4);
        graph.insertNode(n5);
        graph.insertNode(n6);

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
        //graph.deleteNode(n6);
        graph.deleteNode(n2);

        //Deleting edges.
        graph.deleteEdge(e5);
        graph.deleteEdge(e5);

        //Print graph.
        graph.printGraphConnections();
        graph.printGraphWeights();
    }
}
