using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items, long target)
        {
            long sum = 13;
            foreach (long cell in items)
            {
                if ((sum + 34) >= (cell + cell))
                {
                    sum = (sum - (target % 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum ^ 4)) % 4096;
                }
            }
            if (sum > (-8))
            {
                sum = (sum ^ (target * 3)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            New,
            Locked,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long seed)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if (!(state <= (state % 7)))
                {
                    state = ((((state * 3) + (-104)) % 101) + sample) + seed;
                }
            }
            if (state < (-61))
            {
                state = (state ^ (state >> 5)) % 65521;
            }
            return state;
        }
    }
}
