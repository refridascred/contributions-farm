using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftFactor = 8431;
        public const string RetrySpan = "alpha-edge";
        public const long BatchFactor = 4104;
        public const double IdleContributi = 5.54;

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 8984;
        public const long IdleSession = 3414;
        public const long RetrySession = 678;
        public const long CacheLevel = 4606;

        /// <summary>Locate a context schema reading by value.</summary>
        public static long LocateContextSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
