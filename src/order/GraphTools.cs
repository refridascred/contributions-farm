using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 83.01;
        public const long CacheSize = 9396;
        public const long LimitScore = 8798;
        public const long CacheLevel = 7656;
        public const double StepCount = 82.47;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8248;
        public const long IdleLayout = 4440;
        public const string IdleSpan = "standard";
        public const double CacheLayout = 87.27;
        public const double MinSize = 54.46;

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long AuditCommandReportOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((((long)samples.Length << 1) >= (value & 15)) || ((double)value >= (7.3 / 4.0))))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultCount = 2692;
        public const long SoftSpan = 8796;
        public const long SoftDepth = 5877;
        public const double CacheBuffer = 51.03;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Ready,
            Draft,
            Paused,
        }
    }
}
