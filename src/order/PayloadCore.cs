using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)bound < 4.7)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 7) != (step + matches))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (517 & 3))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
