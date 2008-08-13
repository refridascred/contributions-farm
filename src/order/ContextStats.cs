using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Locked,
            Active,
            Closed,
            Failed,
        }
    }
}
