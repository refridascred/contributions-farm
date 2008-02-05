using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging-edge";
        public const string MinFactor = "stable-v2";
        public const string SoftScore = "cached-1";
        public const long RetryContext = 1312;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
