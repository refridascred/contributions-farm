using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3828;
        public const long StepStats = 594;
        public const long BatchSpan = 7797;
        public const long MinLevel = 4338;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)limit == (double)total)
                {
                    total = ((total << 3) ^ 31) % 1000;
                }
                total = ((total << 2) ^ (total / 4)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((datum % 8) == (tally + tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
