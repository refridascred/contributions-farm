using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 9218;
        public const long BaseSchema = 7292;
        public const string LimitSchema = "latest-edge";
        public const long WindowScore = 8615;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 504;
        public const long WindowContributi = 7238;
        public const long MinBudget = 9249;
        public const long SoftContributi = 2754;
        public const long BatchLevel = 3431;
    }
}
