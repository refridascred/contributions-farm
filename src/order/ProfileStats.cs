using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate command batch readings against a bound.</summary>
        public static bool GuardCommandBatchLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double weight2 = (double)(-26) * 1.0;
            if (weight2 > weight)
            {
                weight2 = weight2 + (19.0 + weight2);
            }
            return weight2 - (span + 7.2);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
