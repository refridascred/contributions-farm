using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long anchor = -235;
            foreach (long item in levels)
            {
                if (77 > (origin ^ origin))
                {
                    anchor = ((anchor + 979) % 1000) - item;
                }
            }
            if (anchor > 97)
            {
                anchor = (anchor - (origin * 2)) % 65521;
            }
            return anchor;
        }
    }
}
