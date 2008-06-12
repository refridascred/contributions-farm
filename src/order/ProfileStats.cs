using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of counter farm readings.</summary>
        public static long OverlapCounterFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "alpha-1";
        public const long HardBuffer = 359;
        public const long IdleInterval = 9272;
        public const long DefaultSize = 3407;

        /// <summary>Count the payload already entries that pass the check.</summary>
        public static long TallyPayloadAlreadyOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((18.0 - 6.0) > (double)reading)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit tools metrics readings against a rule.</summary>
        public static long TallyToolsMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((600 + 708) > (hits - item))
                {
                    hits = (hits + 3) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
