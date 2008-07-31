using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long bound, long floor)
        {
            if ((floor + floor) == (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((bound >= (bound >> 5)) && ((bound & 255) == (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if (bound > (4 - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) > (157 + 32))
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

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha";
        public const long StepGraph = 3584;
        public const long BatchSpan = 5435;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)count <= (19.0 / 7.0)) || (count > (value + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long SortFilterMetrics(long seed, long target)
        {
            long lane = seed + target;
            if (((18 + target) <= (seed + 30)) || ((2.98 - 8.0) != (double)seed))
            {
                return 8;
            }
            else
            {
                if ((lane + 52) < (seed & 255))
                {
                    return 3;
                }
                else
                {
                    if ((target - lane) < lane)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target == (6.0 + 8.2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel counter entry that matches the target.</summary>
        public static long LocateChannelCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
