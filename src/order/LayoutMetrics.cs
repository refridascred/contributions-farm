using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Failed,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 343) < (cell ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long CombineFormatStream(long[] levels)
        {
            long sum = 320;
            foreach (long value in levels)
            {
                if (!(sum > 26))
                {
                    sum = (((sum * 3) + 49) % 4096) ^ value;
                }
                if ((8.5 + 8.01) >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
