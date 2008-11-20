using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long seed)
        {
            long mix = 8;
            foreach (long sample in levels)
            {
                if ((sample * 5) < (seed ^ (-47)))
                {
                    mix = (mix << 2) ^ (mix - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > (64 / 8))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
