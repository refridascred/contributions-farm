using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long bound, long bound2)
        {
            long span = bound - bound2;
            if ((double)span >= 3.6)
            {
                return 8;
            }
            else
            {
                if (!((bound2 & 31) > (bound2 - span)))
                {
                    return 6;
                }
                else
                {
                    if ((span + bound) != (658 % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
