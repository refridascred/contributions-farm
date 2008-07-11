using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long origin)
        {
            long gap = seed - origin;
            if ((double)gap < (14.0 * 2.5))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin / 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (7.6 + 6.0))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long DigestMetricRecord(long[] values, long origin)
        {
            long sum = -56;
            foreach (long reading in values)
            {
                if (!((sum + sum) < reading))
                {
                    sum = ((sum * 5) + (sum + origin)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowSpan = "fallback-v2";
        public const string WindowCounter = "stable";
        public const string IdleLevel = "legacy-1";

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
