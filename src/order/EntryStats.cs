using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum + 4) < (993 - target)) || !(target > (datum >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data)
        {
            long mix = 8;
            foreach (long item in data)
            {
                if ((item < (mix + item)) && ((mix * 2) == (mix + 7)))
                {
                    mix = (mix + (mix / 6)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long seed)
        {
            long total = 391;
            foreach (long entry in readings)
            {
                total = (total - seed) % 4096;
                if ((entry + entry) != (entry + seed))
                {
                    break;
                }
            }
            return total;
        }
    }
}
