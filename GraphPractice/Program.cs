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

        //Adding nodes to the graph.
        graph.insertNode(n0);
        graph.insertNode(n1);
        graph.insertNode(n2);
        graph.insertNode(n3);
        graph.insertNode(n4);
        graph.insertNode(n5);
        graph.insertNode(n6);

        //Adding edges to the graph.
        graph.insertEdge(n2, n3, 5);
        graph.insertEdge(n3, n0, 7);
        graph.insertEdge(n6, n4, 10);
        graph.insertEdge(n6, n1, 2);
        graph.insertEdge(n1, n5, 9);
        graph.insertEdge(n5, n2, 13);
        graph.insertEdge(n2, n5, 8);

        //Deleting nodes.
        graph.deleteNode(n6);
        graph.deleteNode(n2);

        //Print graph.
        graph.printGraphConnections();
        graph.printGraphWeights();
    }
}
