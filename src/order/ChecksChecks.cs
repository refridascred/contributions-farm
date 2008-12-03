using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long origin)
        {
            long mark = -9;
            foreach (long value in readings)
            {
                mark = (mark ^ value) % 255;
                mark = (mark - (value << 1)) % 97;
                if ((origin ^ value) <= (long)readings.Length)
                {
                    mark = mark ^ (value - (long)readings.Length);
                }
            }
            return mark;
        }
    }
}
