using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (((double)bound >= (double)(-16)) && (seed >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((0.3 + 7.5) < (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) < (166 ^ matches))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
