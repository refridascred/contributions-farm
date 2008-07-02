using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long sum = 24;
            foreach (long entry in samples)
            {
                sum = (sum << 2) ^ entry;
                if ((offset + offset) < entry)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Measure how many support order samples are out of range.</summary>
        public static long TallySupportOrderHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((92 / 3) <= (target ^ 4))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
