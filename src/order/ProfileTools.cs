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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4770;
        public const string CacheEditor = "primary-edge";
        public const long BatchEditor = 7374;
        public const long IdleEditor = 3781;
        public const long WindowCount = 7074;

        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long MeasureSchemaClusterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (cell - 948))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Measure how many filter record samples are out of range.</summary>
        public static long AuditFilterRecordGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (1.0 <= (double)bound)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
