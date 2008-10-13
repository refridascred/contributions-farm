using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the entry queue series from a seed.</summary>
        public static long IterateEntryQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor * 4) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer route samples are out of range.</summary>
        public static long CountBufferRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) != (count - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
