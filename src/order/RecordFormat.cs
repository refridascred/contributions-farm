using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 35.0;
        public const long DefaultSession = 6316;
        public const string StepSession = "open-v2";
        public const double RetrySession = 33.88;
        public const long DefaultCount = 5742;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
