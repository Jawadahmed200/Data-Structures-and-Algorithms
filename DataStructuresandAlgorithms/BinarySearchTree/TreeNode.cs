
namespace DataStructuresandAlgorithms.BinarySearchTree
{
    public class TreeNode
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public TreeNode LeftTreeNode{ get; set; }
        public TreeNode RightTreeNode{ get; set; }
        public TreeNode(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
