using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long SortMetricCounter(long target, long origin)
        {
            long prev = target ^ origin;
            if ((6.0 + 3.88) == (double)origin)
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) > target)
                {
                    return 1;
                }
                else
                {
                    if ((91 + origin) > (origin ^ prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev <= (11.0 + 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seen + seen) != (seen % 16)) && ((entry + (long)data.Length) > 352))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7568;
        public const double CacheCommand = 62.75;
        public const string CacheWidth = "latest-edge";
        public const long DefaultCommand = 3165;
    }
}
