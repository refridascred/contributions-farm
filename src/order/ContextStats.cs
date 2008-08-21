using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double load = (gain * 9.8) / 6.0;
            if (load < (gain - load))
            {
                load = (load + gain) - offset;
            }
            else
            {
                load = load - (load * 8.88);
            }
            return load - (load + load);
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
