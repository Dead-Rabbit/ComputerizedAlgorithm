using System;
using System.Collections.Generic;

namespace Interview
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] intervals = new int[5][];
            intervals[0] = new int[2]{1, 2};
            intervals[1] = new int[2]{3, 5};
            intervals[2] = new int[2]{6, 7};
            intervals[3] = new int[2]{8, 10};
            intervals[4] = new int[2]{12, 16};

            int[] newInterval = new[] {4, 8};
            
            int[][] result = solution.Insert(intervals, newInterval);
            for (int i = 0; i < result.Length; i++) {
                Console.WriteLine("[" + result[i][0] + ", " + result[i][1] + "]");
            }
        }
    }

    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> resultIntervals = new List<int[]>(intervals.Length + 1);
            
            bool flag = false;
            
            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[0] > intervals[i][1])
                {
                    resultIntervals.Add(intervals[i]);
                    continue;
                }

                if (newInterval[1] < intervals[i][0])
                {
                    // 此处为插入值到列表中，表明后面不再进行判断了
                    resultIntervals.Add(newInterval);
                    flag = !flag;
                    for (; i < intervals.Length; i++)
                        resultIntervals.Add(intervals[i]);
                    break;
                }
                
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            }

            if (!flag) {
                resultIntervals.Add(newInterval);
            }

            return resultIntervals.ToArray();
        }
    }
}