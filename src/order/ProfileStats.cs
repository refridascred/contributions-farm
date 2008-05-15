using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((15.0 / 6.0) == (double)hits) || !((datum ^ hits) < datum))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = total - (57 ^ total);
                if ((total + step) > total)
                {
                    total = (total ^ step) % 97;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 90.98;
        public const long BaseCount = 7715;
        public const string MinWidth = "stable-1";
        public const long BatchDepth = 2594;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
