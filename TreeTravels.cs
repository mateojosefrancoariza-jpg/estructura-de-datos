
using System;
using System.Collections.Generic;

// Clase que representa cada nodo del árbol
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

// Clase que contiene los recorridos del árbol
public class TreeTraversals
{
    // 1. Preorden: Root - Left - Right
    public void PreOrder(Node node)
    {
        if (node == null) return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Inorden: Left - Root - Right
    public void InOrder(Node node)
    {
        if (node == null) return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // 3. Posorden: Left - Right - Root
    public void PostOrder(Node node)
    {
        if (node == null) return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // 4. BFS: recorrido por niveles usando Queue FIFO
    public void LevelOrder(Node root)
    {
        if (root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Programa principal
public class Program
{
    public static void Main(string[] args)
    {
        // Construcción del árbol binario
        Node root = new Node(1);

        root.Left = new Node(2);
        root.Right = new Node(3);

        root.Left.Left = new Node(4);
        root.Left.Right = new Node(5);

        root.Right.Left = new Node(6);
        root.Right.Right = new Node(7);

        TreeTraversals tree = new TreeTraversals();

        Console.WriteLine("Recorrido Preorden:");
        tree.PreOrder(root);

        Console.WriteLine("\n\nRecorrido Inorden:");
        tree.InOrder(root);

        Console.WriteLine("\n\nRecorrido Posorden:");
        tree.PostOrder(root);

        Console.WriteLine("\n\nRecorrido BFS (Por niveles):");
        tree.LevelOrder(root);

        Console.WriteLine();
    }
}
