using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Failed,
            Stale,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long sum = 5;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (value ^ value)) % 1000;
                if (sum >= (target + target))
                {
                    sum = (sum - target) % 255;
                }
            }
            if (sum > 7)
            {
                sum = ((sum << 3) ^ target) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxCounter = 35.24;
        public const string HardCounter = "local-edge";
        public const long IdleFactor = 8167;
        public const long BatchCounter = 8511;
        public const long BurstDepth = 4094;
    }
}
