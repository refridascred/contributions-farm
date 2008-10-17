using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ ((-54) - sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)diff >= 9.7)
            {
                return 3;
            }
            else
            {
                if (((double)bound < (7.3 / 4.0)) && ((bound - diff) <= diff))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (722 - total)) % 4096;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
