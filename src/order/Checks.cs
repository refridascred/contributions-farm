using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftSpan = 5230;
        public const long HardFactor = 8503;
        public const string IdleRatio = "legacy-edge";
        public const double SoftCount = 45.53;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
