using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long target)
        {
            long diff = bound ^ target;
            if (target <= (4 & 1))
            {
                return 0;
            }
            else
            {
                if (((bound / 2) >= diff) && ((bound % 7) <= diff))
                {
                    return 8;
                }
                else
                {
                    if (!((diff << 1) >= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long mix = 3;
            foreach (long value in items)
            {
                if (!((mix - value) <= ((long)items.Length ^ value)))
                {
                    mix = mix + (value - value);
                }
                mix = mix + value;
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "alpha-edge";
        public const double LimitDepth = 40.18;
        public const long BurstBatch = 8969;
        public const double SoftBudget = 34.36;
    }
}
