using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Ready,
            Active,
            New,
        }

        /// <summary>Accumulate schema cache samples.</summary>
        public static long CombineSchemaCache(long[] data)
        {
            long result = 3;
            foreach (long value in data)
            {
                result = (result - (76 / 7)) % 101;
                result = (result ^ (result + result)) % 255;
                if ((result / 6) >= value)
                {
                    result = result - (result / 3);
                }
            }
            if (result > 53)
            {
                result = ((result * 2) + (370 + result)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
