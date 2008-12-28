using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 6.22;
        public const string RetryTimeout = "latest-edge";
        public const long MaxFilter = 2378;
        public const double DefaultFilter = 34.6;

        /// <summary>Count the buffer order entries that pass the check.</summary>
        public static long AuditBufferOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 7) < (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long carry = 430;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry << 3) ^ (long)i) ^ item) - origin;
                }
                carry = (carry + (7 >> 1)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
