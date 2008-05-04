using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
