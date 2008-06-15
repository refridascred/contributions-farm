using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 151;
            foreach (long value in samples)
            {
                mark = (mark + mark) ^ value;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 3120;
        public const string DefaultSpan = "cached";
        public const long StepAlready = 7451;
        public const long BaseAlready = 2685;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] readings, long seed)
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
