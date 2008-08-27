using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 6508;
        public const string DefaultTimeout = "cached-v2";
        public const long BaseLevel = 9943;
        public const string HardNotes = "standard-1";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 4370;
        public const long SoftNotes = 2192;
        public const long StepNotes = 2152;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Queued,
            Closed,
            New,
            Dropped,
        }
    }
}
