using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = -943;
            foreach (long item in samples)
            {
                if ((1 + 6) <= (item & 127))
                {
                    result = ((result << 2) ^ (item >> 1)) % 101;
                }
            }
            return result;
        }
    }
}
