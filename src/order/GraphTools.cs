using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series, long target)
        {
            long total = 324;
            foreach (long value in series)
            {
                if (!((value - total) < (-16)))
                {
                    total = (total + (target + target)) % 65521;
                }
            }
            return total;
        }

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
