using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long WindowCount = 9882;
        public const long WindowRatio = 7398;

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "open-edge";
        public const double WindowCommand = 59.75;
        public const long DefaultSize = 4955;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count + count) > count) && !((entry + 724) <= (seed << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a queue route reading by value.</summary>
        public static long LookupQueueRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
