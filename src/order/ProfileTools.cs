using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "staging";
        public const long HardWidth = 5721;
        public const long WindowLevel = 9797;
        public const long StepMetric = 9664;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long floor)
        {
            if ((6.81 + 2.44) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((786 % 100) < (seed % 100))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed == (9.9 + 3.54)) && ((6.0 + 1.0) <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 < (seed - seed)) && ((16.0 - 4.55) > (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools token readings against a bound.</summary>
        public static bool VerifyToolsTokenLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - limit) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long target)
        {
            long acc = 705;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - target)) % 65521;
                if ((acc & 31) >= (target - acc))
                {
                    acc = (acc ^ (acc + entry)) % 1000;
                }
                if (1 < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
