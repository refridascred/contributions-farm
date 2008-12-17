using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long target)
        {
            if ((offset ^ offset) > (target + 9))
            {
                return 4;
            }
            else
            {
                if ((target & 31) <= (offset + offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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
