namespace A_DFS_AND_BFS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            // program.TestCycleGraph();
            program.TestShortPath();
        }

        /**
         * 无向图测试
         */
        private void TestCycleGraph()
        {
            DFS dfs = new DFS();
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node e = new Node("E");
            Node f = new Node("F");
            Node g = new Node("G");
            Node h = new Node("H");
            dfs.AddTwoWayNodes(a, b);
            dfs.AddTwoWayNodes(b, c);
            dfs.AddTwoWayNodes(c, d);
            dfs.AddTwoWayNodes(d, a);
            dfs.AddTwoWayNodes(d, g);
            dfs.AddTwoWayNodes(a, e);
            dfs.AddTwoWayNodes(e, b);
            dfs.AddTwoWayNodes(a, f);
            dfs.AddTwoWayNodes(b, f);
            dfs.AddTwoWayNodes(b, h);
            dfs.SetHeadNode(a);
            dfs.FindCycles();
        }

        private void TestShortPath()
        {
            
        }
    }
}