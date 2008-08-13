using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long anchor = 604;
            foreach (long datum in series)
            {
                anchor = ((anchor * 5) + datum) % 1000;
                if ((datum >> 3) <= (datum + datum))
                {
                    anchor = (anchor - datum) % 255;
                }
                else
                {
                    anchor = anchor - (datum + datum);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long CountBatchesWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits > 13.0)
                {
                    hits = (hits + 2) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitTimeout = 1453;
        public const long DefaultDepth = 9925;
        public const double BatchLevel = 90.86;
        public const long WindowFactor = 5575;
        public const long DefaultChannel = 7902;
    }
}
