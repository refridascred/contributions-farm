using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items, long target)
        {
            long state = 778;
            foreach (long entry in items)
            {
                if (!((long)items.Length != (entry ^ target)))
                {
                    state = (state ^ ((-84) + target)) % 1000;
                }
            }
            if (state > 283)
            {
                state = state + target;
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 69.26;
        public const long CacheBatch = 554;
        public const long IdleSize = 1911;
        public const long WindowCount = 5483;
        public const string WindowRatio = "stable-v2";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 71.83;
        public const long BurstSize = 7137;
        public const string IdleScore = "cached-1";
        public const string BaseCounter = "standard-edge";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
