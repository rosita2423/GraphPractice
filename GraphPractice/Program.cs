// See https://aka.ms/new-console-template for more information
using GraphPractice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        //Creating nodes.
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);

        //Creating edges.
        Edge e1 = new Edge(n1, n2);
        Edge e2 = new Edge(n2, n3);
        Edge e3 = new Edge(n3, n4);
        Edge e4 = new Edge(n4, n1);

    }
}
