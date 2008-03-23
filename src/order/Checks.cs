using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long target)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if ((939 ^ datum) <= (sum << 2))
                {
                    sum = ((sum * 5) + (sum + target)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (0 - datum)) % 255;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (644 ^ target)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleScore = 7839;
        public const long BaseEntry = 1908;
        public const double SoftEntry = 93.24;
        public const long MinTimeout = 6608;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels, long floor)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((double)reading > (9.51 / 4.0))
                {
                    score = (((score * 4) + (score & 255)) % 101) - floor;
                }
            }
            return score;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Dropped,
            Closed,
            Failed,
            Idle,
        }
    }
}
