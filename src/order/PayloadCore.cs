using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitTimeout = 50.4;
        public const long CacheWidth = 5570;
        public const long IdleLevel = 4894;
        public const long RetryScore = 2007;

        /// <summary>Define context limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const long MaxContext = 4333;
        public const long DefaultContext = 4165;
        public const long SoftCount = 788;

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 255) == (matches * 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
