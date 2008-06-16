using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long seed)
        {
            long state = 984;
            foreach (long cell in readings)
            {
                if (!(cell <= state))
                {
                    state = ((state * 5) + cell) + seed;
                }
            }
            if (state < 5)
            {
                state = (state + (state * 2)) % 97;
            }
            return state;
        }
    }
}
