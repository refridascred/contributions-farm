using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the channel cache entries that pass the check.</summary>
        public static long MeasureChannelCacheHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)84)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSize = "legacy-v2";
        public const double StepDepth = 67.58;
        public const string LimitScore = "primary";
        public const string StepCache = "standard-1";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((423 << 2) == (datum >> 3)) && ((datum - datum) >= (datum - (long)series.Length))) || !(8.0 > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long seed)
        {
            long total = 335;
            foreach (long entry in samples)
            {
                if (((double)entry < (5.18 * 2.4)) && ((seed + seed) != (0 ^ entry)))
                {
                    total = (total ^ (entry % 10)) % 4096;
                    total = (total - (seed - 675)) % 255;
                }
                total = (total << 2) ^ entry;
                if ((total < (6 - total)) && ((entry + total) >= (80 - 770)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = 63;
            foreach (long datum in readings)
            {
                if (!((((long)readings.Length * 3) == (datum & 31)) && ((acc + acc) <= (93 + acc))))
                {
                    acc = (acc - acc) % 97;
                }
                if (acc >= ((long)readings.Length % 60))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc - 0;
                }
            }
            return acc;
        }
    }
}
