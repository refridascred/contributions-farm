using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits > (entry / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 9877;
        public const long IdleGraph = 1620;
        public const double SoftTimeout = 15.69;
        public const string RetryGraph = "primary-edge";
        public const string CacheSize = "legacy-v2";

        /// <summary>Iterate the metrics graph series from a seed.</summary>
        public static long StepMetricsGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 2) + (7 - result);
                if ((4.4 * 8.48) >= (double)result)
                {
                    result = (result + (bound >> 3)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (result & 15)) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the window already series from a seed.</summary>
        public static long RollWindowAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if (mark <= (mark - mark))
                {
                    mark = mark - mark;
                    break;
                }
                mark = (mark << 2) ^ (mark ^ 5);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Closed,
            Stale,
            Idle,
            Done,
        }
    }
}
