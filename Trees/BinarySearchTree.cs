using System;

class BSTNode 
{
    public BSTNode left { get; set; }
    public BSTNode right { get; set; }
    public int value { get; set; }

    public BSTNode(int value)
    {
        this.left = null;
        this.right = null;
        this.value = value;
    }
}

class BinarySearchTree
{
    private BSTNode root;
    public BinarySearchTree()
    {
        this.root = null;
    }

    public void insert(int value)
    {
        BSTNode newNode = new BSTNode(value);
        if (this.root == null)
        {
            this.root = newNode;
            return;
        }

        BSTNode currentNode = this.root;
        while (true)
        {
            if (currentNode.value > value)
            {
                if (currentNode.left == null)
                {
                    currentNode.left = new BSTNode(value);
                    return;
                }
                currentNode = currentNode.left;
            }
            else
            {
                if (currentNode.right == null)
                {
                    currentNode.right = new BSTNode(value);
                    return;
                }
                currentNode = currentNode.right;
            }
        }
    }

    public BSTNode lookup(int value)
    {
        if (root == null)
        {
            return null;
        }
        BSTNode currentNode = this.root;
        while (currentNode != null)
        {
            if (value < currentNode.value)
            {
                currentNode = currentNode.left;
            }
            else if (value > currentNode.value)
            {
                currentNode = currentNode.right;
            }
            else
            {
                return currentNode;
            }
        }
        return null;
    }

    public void remove(int value)
    {
        if (root == null)
        {
            return;
        }

        BSTNode nodeToRemove = root;
        BSTNode parentNode = null;
        while (nodeToRemove.value != value)
        { //Searching for the node to remove and it's parent
            parentNode = nodeToRemove;
            if (value < nodeToRemove.value)
            {
                nodeToRemove = nodeToRemove.left;
            }
            else if (value > nodeToRemove.value)
            {
                nodeToRemove = nodeToRemove.right;
            }
        }

        BSTNode replacementNode = null;
        if (nodeToRemove.right != null)
        { //We have a right node
            replacementNode = nodeToRemove.right;
            if (replacementNode.left == null)
            { //We don't have a left node
                replacementNode.left = nodeToRemove.left;
            }
            else
            { //We have a have a left node, lets find the leftmost
                Node replacementParentNode = nodeToRemove;
                while (replacementNode.left != null)
                {
                    replacementParentNode = replacementNode;
                    replacementNode = replacementNode.left;
                }
                replacementParentNode.left = null;
                replacementNode.left = nodeToRemove.left;
                replacementNode.right = nodeToRemove.right;
            }
        }
        else if (nodeToRemove.left != null)
        {//We only have a left node
            replacementNode = nodeToRemove.left;
        }

        if (parentNode == null)
        {
            root = replacementNode;
        }
        else if (parentNode.left == nodeToRemove)
        { //We are a left child
            parentNode.left = replacementNode;
        }
        else
        { //We are a right child
            parentNode.right = replacementNode;
        }
    }


    int COUNT = 5;
    public void printTree(BSTNode node)
    {
        print2DUtil(root, 0);
    }

    private void print2DUtil(BSTNode root, int space)
    {
        // Base case  
        if (root == null)
            return;

        // Increase distance between levels  
        space += COUNT;

        // Process right child first  
        print2DUtil(root.right, space);

        // Print current node after space  
        // count  
        Console.Write("\n");
        for (int i = COUNT; i < space; i++)
        {
            Console.Write(" ");
        }
        Console.Write(root.value + "\n");

        // Process left child  
        print2DUtil(root.left, space);
    }
}