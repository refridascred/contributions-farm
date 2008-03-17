using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally >> 1) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (scale * 4.8)) + (double)(long)i;
            }
            return load + 4.98;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits + reading) <= (hits - 771)) || ((reading / 3) != (33 + 0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Total { get; set; }
            public double Weight { get; set; }
        }
    }
}
