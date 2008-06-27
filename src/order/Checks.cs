using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits % 7) < (4 + item)) || ((double)288 < (double)(long)samples.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            New,
            Paused,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double ratio = (5.5 - span) + (weight + 2.0);
            if (ratio < (double)(-4))
            {
                ratio = ratio + (weight - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Digest a series of commits cache entries.</summary>
        public static long TotalCommitsCache(long[] samples)
        {
            long mix = 25;
            foreach (long cell in samples)
            {
                mix = (mix - mix) - cell;
                mix = ((mix * 4) + (mix % 10)) % 1000;
            }
            return mix;
        }
    }
}
