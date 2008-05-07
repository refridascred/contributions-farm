using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch filter entries that pass the check.</summary>
        public static long TallyBatchFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 1) < hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if (!((item * 5) <= (sum + item)))
                {
                    sum = ((sum << 2) ^ (47 % 64)) % 65521;
                }
                else
                {
                    sum = (sum + (item ^ item)) % 101;
                }
            }
            if (sum > (-7))
            {
                sum = ((sum << 2) ^ (sum + 58)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double floor)
        {
            double scale = (2.82 - rate) / 8.0;
            if (scale < (scale / 4.0))
            {
                scale = (scale - 0.06) - floor;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - scale;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long bound)
        {
            if ((17 ^ bound) != (3 & 3))
            {
                return 1;
            }
            else
            {
                if (((step << 1) > bound) || ((double)bound >= 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (bound >> 5)) && (bound <= 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
