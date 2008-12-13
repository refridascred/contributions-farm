using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 80;
        public const long LimitRatio = 8614;
        public const long LimitWidth = 4785;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long origin)
        {
            long cur = offset + origin;
            if (((747 << 1) >= offset) || ((cur << 1) > (offset & 7)))
            {
                return 4;
            }
            else
            {
                if (offset > (3 ^ cur))
                {
                    return 6;
                }
                else
                {
                    if ((8.0 + 3.38) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool GuardLayoutClusterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool ValidateMetricsMetricRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
