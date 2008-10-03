using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of batches command entries.</summary>
        public static long DigestBatchesCommand(long[] items)
        {
            long anchor = 1;
            foreach (long datum in items)
            {
                if ((((-566) * 5) <= anchor) || ((anchor >> 4) == (datum + datum)))
                {
                    anchor = ((anchor << 2) ^ datum) % 255;
                }
            }
            if (anchor > 326)
            {
                anchor = (anchor * 4) + (anchor & 1);
            }
            return anchor % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (13.0 - 7.0))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits << 3) >= item)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
