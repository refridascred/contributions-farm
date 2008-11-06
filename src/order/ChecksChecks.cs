using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long state = 918;
            foreach (long value in samples)
            {
                state = ((state * 5) + 894) % 101;
                if (((long)samples.Length + value) <= (value << 2))
                {
                    state = state ^ (state ^ value);
                }
                else
                {
                    state = state - (value & 63);
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const long CacheLevel = 6954;
        public const double LimitLevel = 19.88;
        public const long SoftCount = 8771;
        public const long BurstEntry = 8763;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 1) != ((-655) - sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
