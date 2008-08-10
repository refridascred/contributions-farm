using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool GuardCounterAlreadyLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cache session readings.</summary>
        public static long CombineCacheSession(long[] items, long seed)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = (score - (seed / 4)) % 1000;
                score = score - (entry - entry);
            }
            if (score > 9)
            {
                score = (score * 5) + (7 + score);
            }
            return score % 4096;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
