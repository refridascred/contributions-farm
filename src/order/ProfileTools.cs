using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long seed, long limit)
        {
            if ((seed ^ limit) != (limit % 10))
            {
                return 8;
            }
            else
            {
                if ((30 - seed) < (limit + 83))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long limit)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = (((total << 3) ^ value) % 4096) - limit;
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((55 - bound) <= (tally + 7))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
