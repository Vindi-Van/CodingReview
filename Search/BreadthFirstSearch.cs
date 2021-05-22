using System;
using System.Collections.Generic;

class BreadthFirstSearch
{
    //Iterative
    public static List<int> breathFirstSearch(BSTNode currentNode)
    {
        List<int> list = new List<int>();
        Queue<BSTNode> queue = new Queue<BSTNode>();
        queue.Enqueue(currentNode);

        while (queue.Count > 0)
        {
            currentNode = queue.Dequeue();
            list.Add(currentNode.value);
            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }

            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }
        }
        return list;
    }
    //Recurcive
    public static List<int> breathFirstSearchR(Queue<BSTNode> queue, List<int> list)
    {
        if (queue.Count == 0)
        {
            return list;
        }

        var currentNode = queue.Dequeue();
        list.Add(currentNode.value);
        if (currentNode.left != null)
        {
            queue.Enqueue(currentNode.left);
        }

        if (currentNode.right != null)
        {
            queue.Enqueue(currentNode.right);
        }

        return breathFirstSearchR(queue, list);
    }
    /* 
    static void Main(string[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.insert(9);
        tree.insert(4);
        tree.insert(6);
        tree.insert(20);
        tree.insert(170);
        tree.insert(15);
        tree.insert(1);

        var result = breathFirstSearch(tree.root);
        foreach (var item in result)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();

        //Recurcive call
        List<int> list = new List<int>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(tree.root);
        var result2 = breathFirstSearchR(queue, list);
        foreach (var item in result2)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();
    }*/
}