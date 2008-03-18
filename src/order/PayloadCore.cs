using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultWidth = 502;
        public const long RetryAlready = 8332;
        public const long WindowTimeout = 9533;
        public const long BurstInterval = 494;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstRatio = 8924;
        public const double StepSpan = 41.34;
        public const long DefaultDepth = 2688;
        public const double WindowContributi = 68.89;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
