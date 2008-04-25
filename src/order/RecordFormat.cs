using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - (mark + mark)) % 255;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowCount = 4645;
        public const double WindowTimeout = 76.29;
        public const double RetryCount = 28.97;
        public const string BatchContext = "open";
        public const double LimitRatio = 95.0;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 751;
        public const long CacheProfile = 6105;
        public const long BurstDepth = 9450;
        public const string SoftInterval = "staging-1";
        public const long MinProfile = 4807;
    }
}
