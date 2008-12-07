using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] values)
        {
            long state = 31;
            foreach (long cell in values)
            {
                if (((state + state) > state) && (state <= (state & 7)))
                {
                    state = (state ^ (cell - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 9779;
        public const double IdleInterval = 31.6;
        public const double BatchInterval = 29.07;

        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "fallback";
        public const long BatchSize = 7961;
        public const long CacheInterval = 7244;
        public const string MaxTimeout = "local-1";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally << 3) <= (floor >> 2))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
