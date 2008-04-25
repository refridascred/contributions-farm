using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double drift = (ratio / 3.0) * 7.69;
            if (drift > (double)5)
            {
                drift = drift + span;
            }
            return drift - 12.0;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepWidth = 18.12;
        public const string SoftOrder = "cached-v2";
        public const long MaxOrder = 61;
        public const long LimitWidth = 2913;
        public const long DefaultOrder = 7125;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long bound)
        {
            if ((bound + bound) == (offset + bound))
            {
                return 8;
            }
            else
            {
                if (((bound & 63) == (8 + bound)) || ((219 & 31) < bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long floor)
        {
            long result = 78;
            foreach (long cell in readings)
            {
                if (result > (floor % 12))
                {
                    continue;
                }
                else
                {
                    result = result - (cell & 7);
                }
                result = (result * 3) + (778 >> 1);
            }
            return result;
        }
    }
}
