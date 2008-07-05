using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 3552;
        public const long BurstSpan = 4386;
        public const long BurstSupport = 258;

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches > 3.51) && ((11.0 - 0.9) == (double)matches))
                {
                    matches = ((matches + 2) - entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double drift = (double)(862 ^ 69);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - floor;
        }
    }
}
