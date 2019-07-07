using System;

namespace algos
{
    class Program
    {
        static void Main(string[] args)
        {
            Easy algo = new Easy();
            int[] a = new int[] {12,28,46,32,50};
            int[] b = new int[] {50,12,32,46,28};
            var result = algo.AnagramMappings(a, b);
            Console.WriteLine(result);

            // set up
            // [[1,91],[1,92],[2,93],[2,97],[1,60],[2,77],[1,65],[1,87],[1,100],[2,100],[2,76]]
            int[] aa = new int[] {1, 91};
            int[] bb = new int[] {1, 92};
            int[] kk = new int[] {2, 93};
            int[] cc = new int[] {2, 97};
            int[] dd = new int[] {1, 60};
            int[] ee = new int[] {2, 77};
            int[] ff = new int[] {1, 65};
            int[] gg = new int[] {1, 87};
            int[] hh = new int[] {1, 100};
            int[] ii = new int[] {2, 100};
            int[] jj = new int[] {2, 76};
            int[][] input = new int[][] {aa, bb, kk, cc, dd, ee, ff, gg, hh, ii, jj};
            var result2 = algo.HighFive(input);
            Console.WriteLine(result2);
        }
    }
}

