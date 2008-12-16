using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Done,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long seed)
        {
            if ((double)target >= (7.97 * 3.0))
            {
                return 8;
            }
            else
            {
                if (!(target <= (seed - target)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
