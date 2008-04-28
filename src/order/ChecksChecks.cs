using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + entry) != (entry + 885))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metrics command counter forward.</summary>
        public static long DeriveMetricsCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (bound ^ sum)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum + (8 + (long)i2)) % 1000;
                    sum = ((sum << 3) ^ ((-2) & 31)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
