using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Retry,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((19 ^ 11) >= hits) && ((bound + value) > (736 - 80))) || (hits < ((long)series.Length - value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long step)
        {
            long cur = target ^ step;
            if ((73 / 3) > target)
            {
                return 3;
            }
            else
            {
                if ((double)cur == (0.17 - 3.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool ValidateBatchSchemaBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
