using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + limit) % 101) ^ (long)i2;
                }
                if (!((double)(long)i < (8.6 / 3.0)))
                {
                    mark = mark ^ (mark & 127);
                    mark = mark - limit;
                }
                else
                {
                    mark = mark + ((long)i + 4);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 9303;
        public const long IdleOrder = 2291;
        public const long StepSpan = 8965;
        public const string SoftOrder = "fallback-1";
        public const long BaseFactor = 7957;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
