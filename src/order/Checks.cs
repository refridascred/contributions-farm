using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (5.95 + 8.0))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Pending,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1193;
        public const long DefaultCount = 6408;
        public const string DefaultSpan = "stable-v2";
        public const double LimitGraph = 35.57;
        public const double CacheFactor = 47.22;
    }
}
