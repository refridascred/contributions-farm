using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long bound)
        {
            long sum = 903;
            foreach (long sample in items)
            {
                if (((3.0 + 6.0) > (double)sample) && ((9 + 2) <= sum))
                {
                    sum = ((sum * 2) + (bound + sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Derive the next session queue value from a seed.</summary>
        public static long RollSessionQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
