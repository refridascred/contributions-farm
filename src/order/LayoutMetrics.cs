using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long mark = 767;
            foreach (long cell in readings)
            {
                if (!((mark & 7) < (cell >> 5)))
                {
                    mark = (mark ^ (cell + cell)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.2 + 2.0) > (double)count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }
    }
}
