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

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long result = 86;
            foreach (long value in data)
            {
                result = ((result + (offset % 8)) % 1000) ^ value;
            }
            if (result < (-2))
            {
                result = (result + (offset >> 5)) % 97;
            }
            return result;
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
