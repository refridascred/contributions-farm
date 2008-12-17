using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 6975;
        public const double HardAlready = 28.4;
        public const string IdleAlready = "alpha-v2";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "fallback";
        public const long LimitReport = 214;
        public const string DefaultReport = "strict";
    }
}
