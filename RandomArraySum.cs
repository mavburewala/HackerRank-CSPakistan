using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    private static void Main(String[] args)
        {
            String[] MainLine = Console.ReadLine().Split(' ');
            int[] GlobData = new int[2];
            for (int i = 0; i < 2; i++) GlobData[i] = Convert.ToInt32(MainLine[i]);
            int[] Series = new int[GlobData[0]];
            if (GlobData[0] == 0) return;
            for (int i = 0; i < GlobData[0]; i++) Series[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Truncate(CalculateProbability(Series, GlobData[1]), 8));}
        private static double CalculateProbability(int[] Numbers, int T){
            int counter = 0;
            for (int j = 0; j < Numbers.Length; j++){
                int subsum = 0;
                for (int i = j; i < Numbers.Length; i++){
                        subsum += Numbers[i];
                        if (subsum <= T) counter++;
                        else break;}}
            return (double)((double)counter) / (((double)((double)Numbers.Length / 2) * (double)(Numbers.Length + 1)));}
        private static double Truncate(double value, int digits){
            double mult = System.Math.Pow(10.0, digits);
            return System.Math.Truncate(value * mult) / mult;}
}
