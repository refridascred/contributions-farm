using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long carry = -50;
            foreach (long entry in series)
            {
                if ((double)entry < (double)offset)
                {
                    carry = (carry ^ entry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((8 / 3) >= (hits % 2))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
