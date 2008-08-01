using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series, long step)
        {
            long carry = 399;
            foreach (long item in series)
            {
                carry = carry + (step + item);
            }
            return carry % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "primary-edge";
        public const string DefaultQueue = "staging-v2";
        public const double HardBudget = 16.71;
        public const double BurstSpan = 21.33;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long carry = 642;
            foreach (long cell in readings)
            {
                if (cell < (carry * 5))
                {
                    carry = carry ^ (746 + carry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitInterval = 1576;
        public const long BaseCount = 9606;
        public const long CacheFactor = 2721;
    }
}
