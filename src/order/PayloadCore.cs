using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Queued,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Measure how many commits report samples are out of range.</summary>
        public static long MeasureCommitsReportOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((74 & 255) >= (seed - datum)) || (seen > (67 >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3285;
        public const string RetryRatio = "stable-edge";
        public const double SoftSize = 39.16;
        public const long RetrySize = 4969;
    }
}
