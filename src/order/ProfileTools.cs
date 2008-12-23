using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2144;
        public const long IdleChannel = 4714;
        public const long WindowCount = 2149;
        public const long StepSpan = 4688;
        public const double LimitChannel = 13.87;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((target * 2) < 97)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double scale2 = offset;
            return (scale2 + (double)81) + scale;
        }
    }
}
