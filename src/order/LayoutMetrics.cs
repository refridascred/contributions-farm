using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a batch command reading.</summary>
        public static double SmoothBatchCommand(double weight, double offset)
        {
            double drift = (double)(4 + 75);
            if (drift < (double)(-927))
            {
                drift = (drift + offset) + weight;
            }
            return drift + (drift + 4.4);
        }

        /// <summary>Count buffer command pairs that satisfy a relation.</summary>
        public static long PairBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
