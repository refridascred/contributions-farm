using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches > (matches / 2))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first report metric entry that matches the target.</summary>
        public static long FindReportMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long step)
        {
            long gap = offset ^ step;
            if ((step ^ 17) >= (offset ^ 341))
            {
                return 7;
            }
            else
            {
                if ((offset - step) <= (offset % 8))
                {
                    return 5;
                }
                else
                {
                    if ((gap ^ step) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 2) != (gap >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
