using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftScore = 2118;
        public const double MaxRecord = 79.61;
        public const long BaseRecord = 2159;
        public const string HardRecord = "standard-v2";

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long seed)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((double)seed < (5.0 + 6.12))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = score ^ reading;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
