using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a session layout pair into a bucket.</summary>
        public static long RankSessionLayout(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)step < (5.27 + 9.94))
            {
                return 3;
            }
            else
            {
                if ((8 <= (cur - seed)) && ((double)cur >= (double)614))
                {
                    return 6;
                }
                else
                {
                    if ((cur & 7) >= (cur >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
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

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
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
