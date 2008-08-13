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

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
