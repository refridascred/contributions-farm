using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ tally) > (tally * 2))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryBudget = 7787;
        public const string BaseContributi = "latest-1";
        public const string IdleLevel = "alpha-1";
        public const long DefaultBudget = 3902;
        public const long SoftSize = 570;

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long bound)
        {
            long acc = 8;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ (bound + acc)) - sample;
                if (10.0 > (double)acc)
                {
                    break;
                }
            }
            if (acc < (-487))
            {
                acc = (acc ^ (bound ^ acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
