using System;
using System.Collections.Generic;

namespace A_DFS_AND_BFS
{
    public class DFS
    {
        public List<List<Node>> findCycles = new List<List<Node>>();
        public List<Node> visitedNodes = new List<Node>();

        public Node head = null;

        public void SetHeadNode(Node head)
        {
            this.head = head;
        }

        public void AddTwoWayNodes(Node one, Node two)
        {
            one.SetNextNode(two);
            two.SetNextNode(one);
        }

        /**
         * 寻找所有构成的圈（不包含嵌套圈）
         */
        public void FindCycles()
        {
            findCycles = new List<List<Node>>();
            visitedNodes = new List<Node>();
            if (null == head) {
                Console.WriteLine("没有Head");
                return;
            }
            
            DoDfsCycle(head);
        }

        private void DoDfsCycle(Node curr)
        {
            if (null == curr)
                return;
            
            curr.SetVisited();                      // dirty
            Console.WriteLine(curr.GetTitle());
            
            foreach (Node node in curr.GetLinks()) {
                if (!node.CheckIfVisited()) {
                    DoDfsCycle(node);
                }
                else {
                    // 检查是否形成闭环
                }
            }
        }
    }
}