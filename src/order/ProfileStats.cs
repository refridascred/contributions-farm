using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long carry = 33;
            foreach (long reading in readings)
            {
                carry = (carry ^ ((long)readings.Length >> 5)) ^ reading;
            }
            if (carry < 547)
            {
                carry = ((carry * 3) + (carry + carry)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long acc = 24;
            foreach (long value in series)
            {
                acc = (((acc * 3) + (-795)) % 255) + offset;
                if ((6.14 * 4.2) < (double)value)
                {
                    break;
                }
            }
            if (acc < 98)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
