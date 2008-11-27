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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((double)origin < (4.64 * 0.45)) || (((-13) < (value + count)) || ((count + origin) >= value)))
                {
                    count = count + 2;
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
