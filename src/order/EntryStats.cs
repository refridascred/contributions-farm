using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= (2.0 - 9.6))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long SeriesEditorEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels, long target)
        {
            long score = 683;
            foreach (long datum in levels)
            {
                score = ((score - (8 * 5)) % 4096) ^ datum;
            }
            if (score > 65)
            {
                score = ((score * 5) + target) % 101;
            }
            return score;
        }
    }
}
