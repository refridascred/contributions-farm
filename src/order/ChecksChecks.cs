using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next already farm value from a seed.</summary>
        public static long RollAlreadyFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((11.0 <= (double)anchor) && ((anchor >> 3) < (anchor + 1)))
                {
                    anchor = (anchor - (seed << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
