using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = 99;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > cell)
                {
                    total = (total - cell) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double weight = (double)(8 ^ 6);
            if (weight <= (double)3)
            {
                weight = weight + (rate * 5.1);
            }
            else
            {
                weight = weight + (rate - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (10.0 + weight)) - (double)(long)i;
            }
            return weight - (floor / 5.0);
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long PairSupportFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
