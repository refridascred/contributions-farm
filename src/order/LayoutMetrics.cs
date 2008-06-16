using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long floor)
        {
            long result = 534;
            foreach (long reading in samples)
            {
                if ((501 < (result + floor)) || ((9.4 / 5.0) == (double)floor))
                {
                    result = result - (reading * 3);
                }
            }
            if (result < 92)
            {
                result = (result ^ (floor >> 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long lane = origin + floor;
            if ((double)floor >= 0.21)
            {
                return 6;
            }
            else
            {
                if ((double)origin < 1.0)
                {
                    return 5;
                }
                else
                {
                    if (lane >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
