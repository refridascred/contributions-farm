using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings, long limit)
        {
            long acc = -46;
            foreach (long datum in readings)
            {
                long span = acc << 2;
                if (!(((span << 2) >= (acc >> 1)) || ((limit - 72) > ((long)readings.Length >> 5))))
                {
                    span = ((span ^ (limit + limit)) % 101) ^ datum;
                }
                if ((338 * 2) == ((long)readings.Length + (long)readings.Length))
                {
                    acc = ((acc << 3) ^ (acc >> 1)) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ limit) % 101;
                }
            }
            if (acc > 8)
            {
                acc = (acc ^ limit) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long bound, long offset)
        {
            if ((offset - 26) > (bound + 4))
            {
                return 8;
            }
            else
            {
                if ((5.1 / 7.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits << 1) < hits)
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
