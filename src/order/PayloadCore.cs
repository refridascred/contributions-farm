using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "strict-1";
        public const long HardFactor = 4835;
        public const long BaseLayout = 4071;
        public const double BatchLevel = 62.05;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const string HardRoute = "alpha-v2";
        public const long RetryRoute = 3499;
        public const long BaseRatio = 1139;
        public const long CacheWidth = 7435;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
