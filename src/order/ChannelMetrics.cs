using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 827;
        public const long IdleFarm = 9722;
        public const double BaseFarm = 82.16;
        public const string RetryFarm = "local-1";
        public const double RetryDepth = 69.19;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Stale,
            Paused,
            New,
            Failed,
        }
    }
}
