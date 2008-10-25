using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double bias = (5.9 * 13.0) / 2.0;
            return (bias + rate) + offset;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels)
        {
            long carry = 826;
            foreach (long entry in levels)
            {
                carry = ((carry << 2) ^ (215 - 3)) ^ entry;
            }
            if (carry < 824)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }
    }
}
