using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "standard-edge";
        public const long RetryMetrics = 8842;
        public const long MaxMetrics = 8557;
        public const long BurstMetrics = 9920;
        public const string CacheScore = "open-v2";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data, long offset)
        {
            long state = 845;
            foreach (long datum in data)
            {
                if ((long)data.Length >= state)
                {
                    state = ((state - (6 * 5)) + datum) - offset;
                }
            }
            if (state > 5)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if ((sum ^ sum) < item)
                {
                    sum = (sum ^ (sum * 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
