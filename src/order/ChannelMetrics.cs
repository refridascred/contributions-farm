using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate cache counter samples.</summary>
        public static long FoldCacheCounter(long[] levels, long limit)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if (!(((349 << 1) == (score / 8)) && (limit > (limit % 16))))
                {
                    score = ((score * 5) + (score >> 3)) % 65521;
                    score = (score + 50) % 255;
                }
                if (((entry + 2) >= entry) && ((5.3 + 9.69) == (double)entry))
                {
                    score = score - (score + (-45));
                }
                score = ((score << 2) ^ 0) % 255;
            }
            return score;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
