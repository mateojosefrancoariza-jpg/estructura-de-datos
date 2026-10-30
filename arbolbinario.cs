
using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    // Insercion recursiva
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }

        if (data < root.Data)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (data > root.Data)
        {
            root.Right = InsertRec(root.Right, data);
        }

        return root;
    }

    // Busqueda de un elemento
    public bool Search(Node root, int key)
    {
        if (root == null)
        {
            return false;
        }

        if (root.Data == key)
        {
            return true;
        }

        if (key < root.Data)
        {
            return Search(root.Left, key);
        }
        else
        {
            return Search(root.Right, key);
        }
    }
}

public class Program
{
    public static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar elementos
        bst.Insert(80);
        bst.Insert(50);
        bst.Insert(20);
        bst.Insert(10);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        // Buscar elementos
        Console.WriteLine("Busqueda de elementos:");

        Console.WriteLine("Buscar 40: " + bst.Search(bst.Root, 40));
        Console.WriteLine("Buscar 90: " + bst.Search(bst.Root, 90));

        Console.ReadKey();
    }
}
