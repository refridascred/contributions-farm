using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((1 <= (count % 16)) && ((count % 2) < (entry & 31))) || (count < (count & 127)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 6068;
        public const double DefaultInterval = 50.49;
        public const long BatchChannel = 713;

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry + value) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Failed,
            Queued,
            Draft,
        }
    }
}
