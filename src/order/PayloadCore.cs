using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 217;
        public const double WindowTimeout = 46.2;
        public const long LimitTools = 4287;
        public const long CacheScore = 2720;
        public const long DefaultTools = 533;

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long ClassifyFarmLayout(long target, long limit)
        {
            if ((limit / 3) < (target + limit))
            {
                return 4;
            }
            else
            {
                if ((target >> 5) >= 33)
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > 6.0)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 3) != (cell - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
