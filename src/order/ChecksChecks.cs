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

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitTimeout = 1453;
        public const long DefaultDepth = 9925;
        public const double BatchLevel = 90.86;
        public const long WindowFactor = 5575;
        public const long DefaultChannel = 7902;
    }
}
