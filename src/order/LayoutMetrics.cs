using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit counter filter readings against a rule.</summary>
        public static long AuditCounterFilterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) > (count * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((offset * 3) != (offset - 9)))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
