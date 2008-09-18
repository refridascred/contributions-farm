using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 4957;
        public const long BaseBuffer = 6383;
        public const long StepBudget = 1698;
        public const string CacheDepth = "strict";
        public const long BurstBuffer = 9543;

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 88.62;
        public const double BatchRatio = 67.8;
        public const long RetryScore = 689;
        public const long IdleBatch = 9647;

        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample & 3) > (seen / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
