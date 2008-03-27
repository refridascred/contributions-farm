using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up tools queue samples.</summary>
        public static long OverlapToolsQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 4) < (14 / 5))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool GuardFilterWindowBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Retry,
            Dropped,
            Pending,
            Ready,
        }
    }
}
