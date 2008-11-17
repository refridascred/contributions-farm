using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 21.62;
        public const string BaseOrder = "cached-v2";
        public const long BatchRatio = 346;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((target % 3) >= 854))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((hits / 5) >= (hits << 2)) || ((8.9 * 8.78) < (double)offset)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
