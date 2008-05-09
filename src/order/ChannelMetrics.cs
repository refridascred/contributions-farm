using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long carry = 197;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ ((-6) & 15)) % 97) - datum) - step;
            }
            return carry;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long seed, long origin)
        {
            if ((seed + origin) > (seed + 0))
            {
                return 5;
            }
            else
            {
                if (((5.3 - 9.5) < (double)seed) && ((double)origin != (double)seed))
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
}
