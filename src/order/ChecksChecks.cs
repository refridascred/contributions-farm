using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long AuditSchemaClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits == (5.42 / 7.0))
                {
                    hits = ((hits + 2) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long seed)
        {
            long carry = 183;
            foreach (long reading in values)
            {
                if ((double)reading != (18.0 - 8.0))
                {
                    carry = carry - (seed ^ carry);
                }
                else
                {
                    carry = (carry + (0 & 7)) % 101;
                }
            }
            if (carry < 526)
            {
                carry = carry - seed;
            }
            return carry;
        }
    }
}
