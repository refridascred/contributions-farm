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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
