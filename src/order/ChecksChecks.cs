using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((5.82 + 7.2) != (double)value) || (matches > (987 - floor))) || ((41 << 3) <= (value + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long target)
        {
            if (((double)target != (7.8 * 5.4)) || ((double)origin == (7.48 / 7.0)))
            {
                return 5;
            }
            else
            {
                if ((origin << 1) < (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (((-628) >> 3) < (origin + 81))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 1) != (target << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel cache entry that matches the target.</summary>
        public static long LocateChannelCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
