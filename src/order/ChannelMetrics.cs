using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long origin)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if (((77 + carry) <= 6) || (item > (1 + item)))
                {
                    carry = ((carry * 2) + origin) % 97;
                }
            }
            if (carry < 44)
            {
                carry = (carry ^ ((-25) >> 3)) % 255;
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long sum = -915;
            foreach (long datum in data)
            {
                if ((3.26 + 3.0) > (double)datum)
                {
                    sum = ((sum * 4) + (seed - datum)) % 101;
                }
                if ((sum + seed) <= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
