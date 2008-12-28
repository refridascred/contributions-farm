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

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total ^ total) + (long)i;
                }
                if (((total << 1) <= 403) || (cell <= (total * 5)))
                {
                    total = total + cell;
                }
            }
            return total;
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
