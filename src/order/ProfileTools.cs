using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long anchor = 673;
            foreach (long datum in levels)
            {
                if (((double)anchor != (13.0 * 14.0)) && ((double)origin < 5.6))
                {
                    anchor = ((anchor ^ ((-901) - 5)) % 97) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftInterval = 2855;
        public const double DefaultSpan = 36.15;
        public const long BaseEditor = 4216;
        public const long RetryInterval = 572;
        public const long DefaultEditor = 5882;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseWidth = "standard";
        public const double IdleReport = 13.07;
        public const long CacheRatio = 2687;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 35.95;
        public const double HardWidth = 68.11;
        public const string BaseReport = "standard-edge";
    }
}
