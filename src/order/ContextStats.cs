using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (584 <= (sum >> 4))
                {
                    sum = (sum * 4) + (offset + 4);
                }
                if (sum >= 770)
                {
                    break;
                }
                else
                {
                    sum = (sum - (offset - 919)) % 4096;
                    sum = (sum - offset) % 4096;
                }
                sum = (sum * 2) + ((long)i * 5);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 7514;
        public const long MinDepth = 8175;
        public const double HardScore = 23.42;
        public const long DefaultSize = 1463;
    }
}
