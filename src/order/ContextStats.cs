using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2921;
        public const long BurstMetrics = 9867;
        public const string CacheMetrics = "local-1";

        /// <summary>Classify a format filter pair into a bucket.</summary>
        public static long ClassifyFormatFilter(long origin, long offset)
        {
            long slot = origin - offset;
            if ((double)slot >= (17.0 - 5.69))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if ((94 / 2) <= slot)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin + offset) == ((-814) + slot)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
