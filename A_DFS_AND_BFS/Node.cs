using System;
using System.Collections.Generic;

namespace A_DFS_AND_BFS
{
    public class Node
    {
        private string _title;
        private List<Node> _links = new List<Node>();
        private bool _visited = false;

        #region 属性

        public List<Node> GetLinks()
        {
            return _links;
        }

        public String GetTitle()
        {
            return _title;
        }

        public bool CheckIfVisited()
        {
            return _visited;
        }

        public void SetVisited()
        {
            _visited = true;
        }


        #endregion

        public Node(string title)
        {
            _title = title;
        }

        public void SetNextNode(Node next)
        {
            if (!_links.Contains(next))
                _links.Add(next);
        }

        public List<Node> GetNextNodes()
        {
            return _links;
        }

    }
}