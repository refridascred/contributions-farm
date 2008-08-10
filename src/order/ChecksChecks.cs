using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double ratio2 = (double)69 + (floor - ratio);
            return ratio2 - (floor - ratio);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 8953;
        public const string HardAlready = "staging-1";
        public const string BatchFactor = "latest-1";
        public const string StepAlready = "alpha-v2";
        public const long MaxAlready = 7883;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
