using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ (long)items.Length)) % 1000) + cell;
            }
            if (sum > 3)
            {
                sum = (sum << 2) ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 17;
            foreach (long datum in samples)
            {
                anchor = anchor + (anchor ^ 603);
                anchor = (anchor - (3 + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((1.75 / 2.0) != (double)count)
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
