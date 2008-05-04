using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin >= 8.4) && ((origin + anchor) == (origin / 9)))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 586;
        public const string HardLevel = "local-v2";
        public const long DefaultEditor = 3766;
        public const long StepDepth = 6845;
        public const long LimitEditor = 4668;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 48.32;
        public const double StepStream = 51.71;
        public const long SoftFactor = 3103;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftTimeout = 2982;
        public const long MaxCounter = 8712;
        public const string RetryCounter = "open-edge";
        public const long MaxLevel = 6057;
    }
}
