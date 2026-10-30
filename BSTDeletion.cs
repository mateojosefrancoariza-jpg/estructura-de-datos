csharp

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

    // Insertar un elemento
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Buscar un elemento
    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        if (key < root.Data)
            return Search(root.Left, key);

        return Search(root.Right, key);
    }

    // Eliminar un elemento
    public void Delete(int key)
    {
        Root = DeleteNode(Root, key);
    }

    private Node DeleteNode(Node root, int key)
    {
        if (root == null)
            return null;

        if (key < root.Data)
        {
            root.Left = DeleteNode(root.Left, key);
        }
        else if (key > root.Data)
        {
            root.Right = DeleteNode(root.Right, key);
        }
        else
        {
            // Caso 1: No tiene hijos o solo tiene hijo derecho
            if (root.Left == null)
                return root.Right;

            // Caso 2: Solo tiene hijo izquierdo
            if (root.Right == null)
                return root.Left;

            // Caso 3: Tiene dos hijos
            root.Data = MinValue(root.Right);

            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Obtener el menor valor del subarbol
    private int MinValue(Node root)
    {
        while (root.Left != null)
        {
            root = root.Left;
        }

        return root.Data;
    }

    // Recorrido InOrder
    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Insertar elementos
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);

        Console.WriteLine("Arbol original:");
        bst.InOrder(bst.Root);

        // Eliminar el nodo 30
        bst.Delete(30);

        Console.WriteLine("\nArbol despues de eliminar el 30:");
        bst.InOrder(bst.Root);

        // Buscar elementos
        Console.WriteLine("\nBuscar 30: " + bst.Search(bst.Root, 30));
        Console.WriteLine("Buscar 40: " + bst.Search(bst.Root, 40));

        Console.WriteLine("\n");
        Console.WriteLine("Programa finalizado.");
    }
}