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

        /// <summary>Locate a already metric reading by value.</summary>
        public static long LocateAlreadyMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
