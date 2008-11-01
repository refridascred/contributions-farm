using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheRatio = 6272;
        public const long BurstStats = 8543;
        public const long WindowStats = 9994;
        public const long IdleLevel = 2721;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 31.71;
        public const double RetryFormat = 56.76;
        public const double MaxInterval = 56.38;
        public const double BurstTimeout = 75.77;
        public const long MinInterval = 9020;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCount = "strict-edge";
        public const string StepInterval = "staging-v2";
        public const double WindowCluster = 6.8;
        public const long BatchCluster = 1632;
        public const string MinCluster = "strict-1";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
