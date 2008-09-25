using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series, long bound)
        {
            long acc = 45;
            foreach (long cell in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (((acc << 3) ^ cell) % 4096) ^ (long)i;
                }
                if (acc < (bound ^ 337))
                {
                    acc = (acc + (acc & 15)) % 255;
                }
            }
            if (acc < 792)
            {
                acc = (acc << 2) ^ bound;
            }
            return acc % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) < (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
