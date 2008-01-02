using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long origin)
        {
            if ((bound > (origin + bound)) || (origin >= (38 * 5)))
            {
                return 6;
            }
            else
            {
                if (!(482 >= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((38 >> 1) != (datum >> 2))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long limit)
        {
            long total = 84;
            foreach (long value in series)
            {
                total = (total ^ limit) % 97;
                total = (total - (value / 9)) % 97;
                if ((double)value < (double)2)
                {
                    break;
                }
            }
            return total;
        }
    }
}
