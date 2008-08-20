using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((floor <= reading) || ((double)reading != (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the cache layout entries that pass the check.</summary>
        public static long AuditCacheLayoutOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + value) == (value & 255))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long floor, long offset)
        {
            long next = floor - offset;
            if ((9.3 / 7.0) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((5.0 - 10.0) != (double)next)
                {
                    return 5;
                }
                else
                {
                    if (((floor % 24) <= 465) || ((offset % 7) != (721 + next)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.5 / 3.0) >= (double)offset) || ((next + offset) > 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
