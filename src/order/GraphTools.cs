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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (3.0 + 8.0))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
