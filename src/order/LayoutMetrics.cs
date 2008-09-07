using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            New,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            if ((18.0 + 0.9) > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((150 + floor2) == (floor2 + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor * 5) <= (floor2 - floor)) && ((6.7 / 6.0) > (double)floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
