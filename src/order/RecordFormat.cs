using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 763;
        public const double SoftFarm = 30.92;
        public const long RetryFarm = 5183;
        public const long IdleFarm = 61;

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long score = 15;
            foreach (long value in values)
            {
                long lane = value;
                if ((value > (lane & 1)) || (lane > (927 << 2)))
                {
                    score = (score - (value & 3)) % 101;
                }
                if ((70 + bound) > (value % 24))
                {
                    score = (score + (3 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowSize = "latest";
        public const string BaseQueue = "fallback";
        public const long CacheScore = 3539;
        public const long BurstRatio = 4416;
        public const long RetryWidth = 1673;
    }
}
