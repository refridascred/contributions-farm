using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a layout cluster reading by value.</summary>
        public static long LookupLayoutClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double weight, double bias)
        {
            double scale = (double)258;
            if (scale > scale)
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            return scale + weight;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Queued,
            Locked,
            New,
            Active,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] data)
        {
            long score = 23;
            foreach (long datum in data)
            {
                score = (score - (score + datum)) % 101;
            }
            return score;
        }
    }
}
