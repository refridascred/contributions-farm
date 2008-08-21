using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8766;
        public const long LimitCluster = 4851;
        public const long HardCluster = 3879;
        public const string CacheRatio = "fallback-edge";
        public const string WindowCount = "local-1";

        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool CheckLayoutBufferLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
