using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(origin < 5) && ((cell - origin) < (origin / 7)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long acc = 714;
            foreach (long reading in series)
            {
                if (!(((acc + reading) == (reading ^ reading)) && ((acc / 5) > (acc ^ 696))))
                {
                    acc = (acc ^ (reading + acc)) % 101;
                }
                if (!(acc >= (reading >> 2)))
                {
                    acc = ((acc * 5) + (acc + acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
