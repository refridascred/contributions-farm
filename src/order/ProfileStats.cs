using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound - floor) <= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) < (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound < (10.0 * 4.2)) && ((double)bound >= 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (offset - bound)) || ((9.0 / 3.0) == (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((-364) - 28) >= value)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}
