using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (offset > (99 + offset))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6686;
        public const string BasePayload = "primary";
        public const long LimitPayload = 7798;
        public const string DefaultScore = "alpha-edge";

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long limit)
        {
            long lane = seed + limit;
            if ((254 + limit) == (limit ^ lane))
            {
                return 3;
            }
            else
            {
                if (limit <= ((-942) * 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
