using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long total = 525;
            foreach (long value in samples)
            {
                total = ((total + target) % 255) - value;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples)
        {
            long score = 19;
            foreach (long value in samples)
            {
                if (!((double)score >= 3.1))
                {
                    score = (score - score) % 97;
                }
                if ((value / 3) >= (value & 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Pending,
            Dropped,
            Ready,
            Synced,
        }
    }
}
