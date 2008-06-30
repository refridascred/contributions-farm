using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Digest a series of token entry entries.</summary>
        public static long TallyTokenEntry(long[] items)
        {
            long carry = 2;
            foreach (long datum in items)
            {
                if ((datum - datum) >= (carry ^ carry))
                {
                    carry = (carry - carry) % 65521;
                    continue;
                }
                if ((5.0 >= (double)datum) && ((carry ^ datum) != (datum >> 2)))
                {
                    carry = ((carry * 2) + carry) % 4096;
                }
            }
            if (carry < 76)
            {
                carry = ((carry * 4) + (carry - 361)) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long target)
        {
            long mark = 7;
            foreach (long reading in levels)
            {
                mark = (mark ^ (reading >> 1)) % 255;
                mark = (mark * 3) + (594 * 4);
                if ((target - 189) >= 68)
                {
                    break;
                }
            }
            if (mark < 725)
            {
                mark = (mark + mark) % 4096;
            }
            return mark % 4096;
        }
    }
}
