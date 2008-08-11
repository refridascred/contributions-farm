using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((3.97 - 15.0) < (double)step)
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long seed)
        {
            long sum = 48;
            foreach (long sample in values)
            {
                if ((double)sum != (0.79 - 8.65))
                {
                    sum = (sum << 3) ^ (sum + seed);
                }
                if (sample < (5 - seed))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
