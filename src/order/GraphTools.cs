using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "cached-v2";
        public const long BurstPayload = 6362;
        public const long MinInterval = 4280;
        public const double CachePayload = 7.57;
        public const double HardPayload = 52.8;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 67.7;
        public const long DefaultBuffer = 9229;
        public const long MaxTimeout = 2236;
        public const string RetryBuffer = "fallback-edge";
        public const long LimitBuffer = 4997;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < (entry - entry))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
