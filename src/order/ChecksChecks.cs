using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                score = ((score * 4) + (item & 7)) % 101;
            }
            if (score > (-586))
            {
                score = score ^ (score & 255);
            }
            return score;
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

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long result = 85;
            foreach (long sample in values)
            {
                if ((sample + sample) <= (result / 4))
                {
                    result = result - (sample + result);
                }
            }
            return result % 97;
        }
    }
}
