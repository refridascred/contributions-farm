using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (offset3 > (93 >> 5))
            {
                return 6;
            }
            else
            {
                if ((offset3 + offset) > (offset3 & 15))
                {
                    return 7;
                }
                else
                {
                    if (9.99 >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset3 & 63) >= (722 ^ offset3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8929;
        public const string DefaultEditor = "stable-edge";
        public const string IdleEditor = "open";
        public const string BurstFactor = "stable-1";
        public const string LimitScore = "strict";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
