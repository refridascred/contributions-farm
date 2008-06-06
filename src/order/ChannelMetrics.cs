using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long sum = 19;
            foreach (long cell in samples)
            {
                sum = (((sum << 3) ^ (3 + cell)) % 1000) - target;
                if ((cell << 3) >= (cell - (long)samples.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((17 / 8) > (sample >> 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] values, long offset)
        {
            long score = -46;
            foreach (long sample in values)
            {
                if ((43 + sample) < (score >> 2))
                {
                    long lane = (score / 8) << 1;
                    score = ((score + (score - lane)) % 65521) - offset;
                }
                score = score ^ (sample - score);
            }
            return score % 65521;
        }
    }
}
