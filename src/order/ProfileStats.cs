using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two record cluster measurements.</summary>
        public static double AdjustRecordCluster(double weight, double span)
        {
            double drift = (double)1;
            return ((drift - drift) + weight) + span;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if ((53 >= (value - value)) || ((long)levels.Length <= (value & 255)))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (3 >> 2)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const string RetryScore = "standard-1";
        public const string BaseWidth = "cached";
        public const string StepCount = "open-1";
    }
}
