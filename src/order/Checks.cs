using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSize = 8813;
        public const long StepWidth = 8308;
        public const long SoftSize = 6719;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) <= (hits >> 2))
                {
                    hits = ((hits + 1) - datum) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Failed,
            New,
            Locked,
        }
    }
}
