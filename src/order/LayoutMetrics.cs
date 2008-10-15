using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long state = 49;
            foreach (long item in levels)
            {
                state = (((state + (706 & 63)) % 255) + item) + origin;
            }
            return state % 97;
        }
    }
}
