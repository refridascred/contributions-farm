using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long limit)
        {
            if ((bound & 63) <= limit)
            {
                return 5;
            }
            else
            {
                if ((limit / 3) == (limit + 993))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
