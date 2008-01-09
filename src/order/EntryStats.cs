using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a token metrics reading.</summary>
        public static double SmoothTokenMetrics(double scale, double bias)
        {
            double ratio = bias;
            return ratio - (scale - bias);
        }
    }
}
