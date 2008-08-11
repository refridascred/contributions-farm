using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long IterateCounterFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i / 2) < (1 % 8)) || ((long)i < (limit - limit)))
                {
                    acc = (acc + (-3)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
