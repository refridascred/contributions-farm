using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowDepth = 45.89;
        public const double BurstNotes = 6.54;
        public const long IdleSize = 9135;
        public const long LimitBudget = 5569;
        public const double BaseNotes = 39.44;

        /// <summary>Match up githubfarm record samples.</summary>
        public static long CompareGithubfarmRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "standard-1";
        public const string HardReport = "staging-v2";
        public const long RetryInterval = 5699;
        public const double BatchDepth = 89.31;
        public const long WindowLevel = 3192;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "alpha-edge";
        public const long StepWidth = 5662;
        public const long CacheWindow = 6053;
        public const long StepBudget = 8069;
        public const long DefaultWindow = 2342;
    }
}
