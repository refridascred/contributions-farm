using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit githubfarm token readings against a rule.</summary>
        public static long AuditGithubfarmTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((8.2 + 3.6) < (double)tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
