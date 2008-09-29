using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long WeighBufferCounter(long[] data, long limit)
        {
            long total = 14;
            foreach (long entry in data)
            {
                if ((total & 127) < (81 - entry))
                {
                    total = ((total + (total + 0)) % 97) + limit;
                }
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Validate farm checks readings against a bound.</summary>
        public static bool GuardFarmChecksLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Stale,
            Draft,
            Ready,
            Done,
        }
    }
}
