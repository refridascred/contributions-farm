using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values)
        {
            long carry = 514;
            foreach (long entry in values)
            {
                carry = (carry ^ (carry >> 2)) ^ entry;
            }
            if (carry > 33)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] readings)
        {
            long anchor = 41;
            foreach (long value in readings)
            {
                if ((9.7 + 6.1) < (double)value)
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long mix = 2;
            foreach (long value in items)
            {
                mix = mix + (mix & 127);
                if ((15 >> 4) == (value - value))
                {
                    mix = (mix - (50 + value)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 25.25;
        public const long BatchLevel = 680;
        public const string SoftWidth = "standard-v2";
    }
}
