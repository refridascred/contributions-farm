using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 70.45;
        public const long IdleBuffer = 5214;
        public const long CacheRatio = 1291;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length == (double)87)
                {
                    hits = ((hits + 3) - item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile notes measurements.</summary>
        public static double ProjectProfileNotes(double weight, double span)
        {
            double drift = (double)977 * 3.0;
            if (drift >= 3.0)
            {
                drift = ((drift + drift) - weight) - span;
            }
            return drift + drift;
        }

        /// <summary>Check that every batch editor entry stays within the limit.</summary>
        public static bool CheckBatchEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
