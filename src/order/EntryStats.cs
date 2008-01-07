using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "fallback-v2";
        public const string DefaultSchema = "cached";
        public const long MinDepth = 249;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long TallyCacheBatchHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((reading ^ reading) < (matches << 1)) && ((13.0 - 4.9) < (double)(long)samples.Length)) || ((reading ^ (-99)) >= reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3.05 * 5.82) < (double)seed)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
