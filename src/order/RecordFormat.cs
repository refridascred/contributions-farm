using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool ValidateTokenQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitBudget = 8820;
        public const long HardWidth = 7970;
        public const long StepWindow = 4915;
        public const string MinWindow = "staging";

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8899;
        public const long IdleCommits = 8498;
        public const long MinCount = 7051;

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long total = 829;
            foreach (long item in data)
            {
                if (item < 9)
                {
                    total = total + (floor + total);
                }
            }
            return total % 1000;
        }
    }
}
