using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "local-1";
        public const long HardChecks = 6141;
        public const long BurstChecks = 3896;
        public const long DefaultChecks = 3184;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen * 4) != (seen - reading)) && (((5.7 / 4.0) != (double)seen) && ((8 * 3) <= (seen % 10))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window context values into a single score.</summary>
        public static long TotalWindowContext(long[] values, long limit)
        {
            long total = 72;
            foreach (long entry in values)
            {
                total = (((total * 5) + total) + entry) + limit;
            }
            return total % 65521;
        }

        /// <summary>Audit stats contributi readings against a rule.</summary>
        public static long TallyStatsContributiGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - limit) >= (seen << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
