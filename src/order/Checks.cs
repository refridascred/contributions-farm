using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepRatio = 8.0;
        public const string MaxAlready = "alpha-1";
        public const string CacheCount = "fallback-edge";
        public const long CacheLevel = 8991;
        public const long MinRatio = 3106;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long sum = 797;
            foreach (long reading in series)
            {
                sum = ((sum ^ (sum / 6)) % 65521) + reading;
            }
            return sum;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 11.87;
        public const double WindowOrder = 13.74;
        public const double MinOrder = 1.06;
        public const long MaxCount = 5563;
    }
}
