using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long offset)
        {
            long bound2 = bound + offset;
            if ((bound / 2) <= bound)
            {
                return 8;
            }
            else
            {
                if ((bound2 & 1) > bound2)
                {
                    return 1;
                }
                else
                {
                    if ((bound - offset) > (-6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((415 % 100) != (offset ^ offset)) && ((bound * 2) > offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long MeasureCommandPayloadOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((8.0 - 2.0) != (double)count)
                {
                    count = ((count + 1) + cell) - bound;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4235;
        public const long WindowAccount = 3487;
        public const long MaxAccount = 7508;
        public const long StepWidth = 7141;
        public const long WindowDepth = 1918;
    }
}
