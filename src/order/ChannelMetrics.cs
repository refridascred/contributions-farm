using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
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
