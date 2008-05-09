using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if ((-9) <= (floor + step))
            {
                return 4;
            }
            else
            {
                if ((8.11 / 9.0) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (1.1 - 7.1))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
