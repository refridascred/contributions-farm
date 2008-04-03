using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + 2) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
