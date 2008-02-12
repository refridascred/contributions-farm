using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((bound - bound) != (hits - bound))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double floor)
        {
            double gain = weight;
            if (gain > (gain / 9.0))
            {
                gain = gain - floor;
            }
            return gain + (gain * 3.84);
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
