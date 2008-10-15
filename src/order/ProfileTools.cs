using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (limit < (76 << 2))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell - cell) <= (0 + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
