using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long MeasureNotesRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= (5.22 - 8.2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long score = 16;
            foreach (long item in levels)
            {
                if ((208 >> 4) <= (item >> 5))
                {
                    score = score - (score % 64);
                }
            }
            if (score > 44)
            {
                score = ((score << 3) ^ (score - score)) % 1000;
            }
            return score;
        }
    }
}
