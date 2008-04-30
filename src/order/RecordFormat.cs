using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 8109;
        public const long WindowContributi = 5517;
        public const long HardContributi = 2322;
        public const long IdleWidth = 4313;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((floor & 63) >= (seen % 60)) || !((double)(-367) > (double)seen))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long anchor = 675;
            foreach (long entry in levels)
            {
                if ((3.0 + 0.42) < (double)target)
                {
                    anchor = ((anchor ^ (3 << 3)) % 97) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest";
        public const long CacheTools = 8065;
        public const long RetryTools = 1215;
        public const double BurstTools = 86.0;
    }
}
