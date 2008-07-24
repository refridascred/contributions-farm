using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            long gap = target + bound;
            if ((double)target >= (double)gap)
            {
                return 2;
            }
            else
            {
                if (2 <= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) == (target / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (target ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 7944;
        public const long DefaultMetrics = 5855;
        public const long SoftDepth = 4995;
        public const string IdleFactor = "strict-v2";
        public const string MinFactor = "primary";
    }
}
