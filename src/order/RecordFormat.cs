using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheSize = 80.19;
        public const long RetryEditor = 663;
        public const double SoftEditor = 51.88;
        public const double HardEditor = 35.23;
        public const string RetryWidth = "local";

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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Pending,
            Locked,
        }
    }
}
