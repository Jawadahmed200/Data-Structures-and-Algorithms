
namespace DataStructuresandAlgorithms.BinarySearchTree
{
    internal class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;

        public void Insert(int key,string value)
        {
            Root = InsertItem(Root, key, value);
        }


        public void PrintInOrderTreeTraversal()
        {
            InOrderTreeTraversal(Root);
        }

        private void InOrderTreeTraversal(TreeNode node)
        {
            if(node is not null)
            {
                InOrderTreeTraversal(node.LeftTreeNode);
                Console.WriteLine(node.Key + " " + node.Value);
                InOrderTreeTraversal(node.RightTreeNode);
            }
        }

        public void PrintPreOrderTreeTraversal()
        {
            PreOrderTreeTraversal(Root);
        }

        private void PreOrderTreeTraversal(TreeNode node)
        {
            if (node is not null)
            {
                Console.WriteLine(node.Key + " " + node.Value);
                InOrderTreeTraversal(node.LeftTreeNode);
                InOrderTreeTraversal(node.RightTreeNode);
            }
        }


        public void PrintPostOrderTreeTraversal()
        {
            PostOrderTreeTraversal(Root);
        }

        private void PostOrderTreeTraversal(TreeNode node)
        {
            if (node is not null)
            {
                InOrderTreeTraversal(node.LeftTreeNode);
                InOrderTreeTraversal(node.RightTreeNode);
                Console.WriteLine(node.Key + " " + node.Value);
            }
        }


        private TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            // For first time node will be null, Create Root.
            if (node == null)
            {
                node = newNode;
                return node;
            }
            //If this is not first time, Traverse, Find null, Insert.

            if(key < node.Key)
            {
                node.LeftTreeNode=InsertItem(node.LeftTreeNode, key, value);
            }
            else
            {
                node.RightTreeNode = InsertItem(node.RightTreeNode, key, value);
            }
            return node;
        }

        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            }
            else if(key < node.Key)
            {
                return Find(node.LeftTreeNode, key);
            }
            else if (key > node.Key)
            {
                return Find(node.RightTreeNode, key);
            }
            return null;

        }
    }
}
