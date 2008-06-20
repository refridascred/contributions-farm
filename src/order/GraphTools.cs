using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 6319;
        public const long IdleScore = 1433;
        public const double RetryToken = 75.69;
        public const string WindowToken = "open";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (9.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Active,
            Failed,
        }
    }
}
