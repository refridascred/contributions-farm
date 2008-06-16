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

        /// <summary>Grade a context schema value against two limits.</summary>
        public static long ClassifyContextSchema(long offset, long target)
        {
            long bound = offset + target;
            if ((bound & 3) > (bound - target))
            {
                return 3;
            }
            else
            {
                if ((offset + 1) < bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Look up the position of a command entry sample.</summary>
        public static long SeekCommandEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
