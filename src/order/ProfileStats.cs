using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long seed)
        {
            long score = 2;
            foreach (long entry in values)
            {
                score = (score - entry) - seed;
                score = ((score << 2) ^ entry) % 4096;
            }
            if (score < 48)
            {
                score = score - (score + 692);
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits + datum) != (hits ^ datum)) || ((double)datum == (double)3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches + matches) < matches) || !((19.0 * 4.24) >= (3.0 * 3.0)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
