using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long origin)
        {
            if ((origin + 699) >= 789)
            {
                return 8;
            }
            else
            {
                if ((origin - target) <= (1 + origin))
                {
                    return 6;
                }
                else
                {
                    if ((target / 9) <= (64 >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long total = 0;
            foreach (long value in items)
            {
                if (value > (-905))
                {
                    total = (total ^ value) % 4096;
                }
                if ((total << 2) <= (total >> 4))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((cell - 6) <= (origin + origin)) || ((14.0 - 19.0) != (double)origin))
                {
                    hits = hits + 2;
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
