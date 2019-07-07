using System;
using System.Collections;
using System.Collections.Generic;

namespace algos
{
    public class Easy
    {
        public int[] AnagramMappings(int[] A, int[] B) 
        {
            var p = new List<int>();
            var map = new Dictionary<int, int>();
            for (var i = 0; i < B.Length; i++) {
                if (!map.ContainsKey(B[i])) {
                    map.Add(B[i], i);
                }
            }
            for (var j = 0; j < A.Length; j++) {
                if (map.ContainsKey(A[j])) {
                    p.Add(map[A[j]]);
                }
            }
            return p.ToArray();
        }

        public int[][] HighFive(int[][] items) {
            // [[1,91],[1,92],[2,93],[2,97],[1,60],[2,77],[1,65],[1,87],[1,100],[2,100],[2,76]]
            var map = new Dictionary<int, List<int>>();
            for (var i = 0; i < items.Length; i++) {
                if (map.ContainsKey(items[i][0])) {
                    int nextVal = items[i][1];
                    map[items[i][0]].Add(nextVal);
                } else {
                    List<int> add = new List<int> {items[i][1]};
                    map.Add(items[i][0], add);
                }
            }
            List<int[]> result = new List<int[]>();
            foreach(KeyValuePair<int, List<int>> entry in map)
            {
                int total = 0;
                foreach(int x in entry.Value) {
                    total += x;
                }
                int[] sum = new int[] {entry.Key, total / entry.Value.Count};
                result.Add(sum);
            }
            return result.ToArray();
        }
    }
}