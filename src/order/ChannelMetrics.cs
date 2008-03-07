using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long target)
        {
            long mix = 591;
            foreach (long value in data)
            {
                mix = ((mix + (value ^ value)) % 1000) + target;
            }
            if (mix < 865)
            {
                mix = mix ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 8195;
        public const double BatchInterval = 34.56;
        public const double BaseCount = 74.84;
    }
}
