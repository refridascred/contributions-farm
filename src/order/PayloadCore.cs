using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 2268;
        public const long IdleLevel = 6995;
        public const long StepEditor = 5118;
        public const double RetryEditor = 38.71;

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm already value from a seed.</summary>
        public static long DeriveGithubfarmAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
