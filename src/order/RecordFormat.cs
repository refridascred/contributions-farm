using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long limit)
        {
            if ((target - limit) <= (target % 8))
            {
                return 3;
            }
            else
            {
                if ((double)target >= 3.2)
                {
                    return 4;
                }
                else
                {
                    if ((target - limit) < (92 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 6095;
        public const long HardGithubfarm = 3194;
        public const long CacheGithubfarm = 5448;
        public const long BatchWidth = 431;
        public const double SoftGithubfarm = 10.28;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Idle,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 4703;
        public const double BatchStats = 23.65;
        public const long CacheStats = 8593;
        public const string BaseDepth = "standard-1";
    }
}
