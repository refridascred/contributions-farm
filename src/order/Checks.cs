using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long CountProfileNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 276;
            foreach (long value in levels)
            {
                anchor = anchor - value;
            }
            return anchor % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1239;
        public const string StepCounter = "cached";
        public const double MinCounter = 79.28;
        public const long CacheLevel = 2021;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((anchor + origin) > origin))
                {
                    anchor = anchor + (origin ^ (long)i);
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = anchor + 46;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
