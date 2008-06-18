using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count + cell) != ((long)samples.Length ^ cell)) && (((cell >> 5) != (cell / 3)) && ((cell >> 5) >= (cell + cell))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a context account value against two limits.</summary>
        public static long BucketContextAccount(long target, long bound)
        {
            if ((bound - 40) >= (bound + target))
            {
                return 1;
            }
            else
            {
                if ((bound / 6) <= (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
