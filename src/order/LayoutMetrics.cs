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

        /// <summary>Validate profile entry readings against a bound.</summary>
        public static bool VerifyProfileEntryLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
