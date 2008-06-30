using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double StepSpan = 35.14;
        public const long SoftTimeout = 3329;
        public const long CacheCounter = 1773;
        public const double StepScore = 22.38;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data)
        {
            long mark = -571;
            foreach (long value in data)
            {
                if ((value << 3) == ((long)data.Length + value))
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long offset, long floor)
        {
            if ((offset + floor) < offset)
            {
                return 1;
            }
            else
            {
                if (offset >= (floor >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) == (8 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
