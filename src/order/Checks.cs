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

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 25.25;
        public const long BatchLevel = 680;
        public const string SoftWidth = "standard-v2";
    }
}
