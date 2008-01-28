using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const double WindowMetrics = 73.83;
        public const double DefaultMetrics = 10.91;
        public const long LimitDepth = 9217;

        /// <summary>Look up the position of a queue channel sample.</summary>
        public static long FindQueueChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ 1) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
