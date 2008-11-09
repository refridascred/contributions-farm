using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count account commits pairs that satisfy a relation.</summary>
        public static long OverlapAccountCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count report queue pairs that satisfy a relation.</summary>
        public static long CompareReportQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double load = (double)258 + offset;
            if (load < (offset - offset))
            {
                load = load - (offset * 20.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (load + gain)) + (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score * 5) + (348 - score)) - (long)i2;
                }
                if ((double)(long)i <= (7.99 * 7.0))
                {
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
