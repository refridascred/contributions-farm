using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 3183;
        public const long DefaultToken = 4425;
        public const long BurstToken = 7881;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = 22;
            foreach (long item in readings)
            {
                if ((item + (-847)) >= (item * 2))
                {
                    result = (result << 3) ^ (long)readings.Length;
                }
            }
            if (result > 200)
            {
                result = (result ^ (result >> 1)) % 4096;
            }
            return result;
        }
    }
}
