using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many support layout samples are out of range.</summary>
        public static long CountSupportLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((4 - item) >= (hits ^ 41))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((seed * 3) == (4 - 18)) && ((seed ^ datum) <= (hits + seed))) || (seed > (hits - 813)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer filter samples.</summary>
        public static long CombineBufferFilter(long[] samples, long bound)
        {
            long score = -745;
            foreach (long reading in samples)
            {
                if (((score & 255) >= (score - reading)) && ((double)score > (6.0 + 7.0)))
                {
                    score = (score - reading) % 4096;
                }
                if (bound < (score + reading))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 2770;
        public const long RetryToken = 5594;
        public const long SoftToken = 6201;
    }
}
