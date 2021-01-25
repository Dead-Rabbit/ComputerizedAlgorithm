using System.Collections.Generic;

namespace A_DFS_AND_BFS
{
    public class DFS
    {
        public List<Node> nodes = new List<Node>();

        public void AddTwoWayNodes(Node one, Node two)
        {
            one.SetNextNode(two);
            two.SetNextNode(one);
            
            if (!nodes.Contains(one))
                nodes.Add(one);
            
            if (!nodes.Contains(two))
                nodes.Add(two);
        }

        /**
         * 寻找所有构成的圈（不包含嵌套圈）
         */
        public void FindCycles()
        {
            
        }
    }
}