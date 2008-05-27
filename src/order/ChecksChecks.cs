using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long RollClusterCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (22 + (long)i)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long origin)
        {
            long sum = 385;
            foreach (long datum in series)
            {
                sum = (sum ^ (5 - sum)) ^ datum;
                if ((origin - origin) < (origin * 2))
                {
                    break;
                }
            }
            if (sum > 12)
            {
                sum = (sum ^ (sum / 6)) % 97;
            }
            return sum;
        }
    }
}
