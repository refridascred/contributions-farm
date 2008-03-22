using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long target)
        {
            if (target <= bound)
            {
                return 7;
            }
            else
            {
                if (((target ^ bound) >= (0 + target)) || (target < (bound << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 - 1.94) >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 9) <= bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = 685;
            foreach (long entry in samples)
            {
                if (((result % 10) <= entry) || ((double)entry > (5.71 / 7.0)))
                {
                    result = result - (46 ^ entry);
                    result = (result - entry) % 101;
                }
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session cluster readings against a rule.</summary>
        public static long CountSessionClusterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (8 <= (hits >> 4))
                {
                    hits = ((hits + 3) ^ sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
