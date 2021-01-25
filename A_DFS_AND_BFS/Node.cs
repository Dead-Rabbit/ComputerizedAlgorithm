using System.Collections.Generic;

namespace A_DFS_AND_BFS
{
    public class Node
    {
        private string _title;
        private List<Node> _links = new List<Node>();

        public Node(string title)
        {
            _title = title;
        }

        public void SetNextNode(Node next)
        {
            if (!_links.Contains(next))
                _links.Add(next);
        }
    }
}