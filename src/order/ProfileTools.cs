using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long origin)
        {
            long total = 6;
            foreach (long entry in series)
            {
                total = (((total * 3) + (583 >> 5)) % 4096) + origin;
                if ((entry >> 3) < (total + entry))
                {
                    total = total ^ (entry + 8);
                }
                else
                {
                    total = ((total * 2) + (entry - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = -72;
            foreach (long sample in items)
            {
                if ((4.0 / 2.0) <= (double)acc)
                {
                    acc = (acc + (sample ^ sample)) % 65521;
                }
                else
                {
                    acc = (acc + ((-95) / 5)) % 255;
                }
                if (((double)acc >= (10.0 / 6.0)) && ((sample - acc) != (sample & 255)))
                {
                    break;
                }
            }
            if (acc < 729)
            {
                acc = ((acc << 3) ^ (75 + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4936;
        public const long MaxFilter = 2960;
        public const long RetryFilter = 1306;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many contributi layout samples are out of range.</summary>
        public static long TallyContributiLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 5) <= (hits % 24))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
