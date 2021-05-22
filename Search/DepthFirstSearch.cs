using System;
using System.Collections.Generic;
class DepthFirstSearch
{
    //Pass in root ndoe
    public static List<int> DFSInOrder(BSTNode root)
    {
        // this.root
        List<int> result = new List<int>();
        traverseInOrder(root, result);
        return result;
    }

    public static List<int> DFSPreOrder(BSTNode root)
    {
        List<int> result = new List<int>();
        traversePreOrder(root, result);
        return result;
    }

    public static List<int> DFSPostOrder(BSTNode root)
    {
        List<int> result = new List<int>();
        traversePostOrder(root, result);
        return result;
    }

    public static List<int> traverseInOrder(BSTNode node, List<int> list)
    {
        if (node.left != null)
        {
            traverseInOrder(node.left, list);
        }
        list.Add(node.value);
        if (node.right != null)
        {
            traverseInOrder(node.right, list);
        }

        return list;
    }

    public static List<int> traversePreOrder(BSTNode node, List<int> list)
    {
        list.Add(node.value);
        if (node.left != null)
        {
            traversePreOrder(node.left, list);
        }
        
        if (node.right != null)
        {
            traversePreOrder(node.right, list);
        }

        return list;
    }

    public static List<int> traversePostOrder(BSTNode node, List<int> list)
    {
        if (node.left != null)
        {
            traversePostOrder(node.left, list);
        }
        
        if (node.right != null)
        {
            traversePostOrder(node.right, list);
        }
        list.Add(node.value);

        return list;
    }

}