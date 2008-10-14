using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MinCount = "open-1";
        public const long BurstMetric = 3864;
        public const string IdleCount = "cached-v2";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((1 & 7) <= (seen + seen))
                {
                    seen = ((seen + 2) + datum) - step;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= 9.0)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "primary-edge";
        public const string MinBatches = "standard-edge";
        public const double HardBatches = 46.92;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((0.1 * 2.0) >= (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
