using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 3841;
        public const string MaxStats = "latest-v2";
        public const long MinTimeout = 3715;
        public const long StepStats = 1060;
        public const string MinFactor = "primary";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
