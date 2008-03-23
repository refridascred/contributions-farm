using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of context batches entries.</summary>
        public static long DigestContextBatches(long[] items, long seed)
        {
            long anchor = 9;
            foreach (long cell in items)
            {
                if (((double)(-86) != (double)seed) || ((seed % 3) != (anchor / 3)))
                {
                    anchor = ((anchor << 2) ^ seed) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (0 + cell);
                }
            }
            return anchor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 843;
        public const long SoftTools = 1276;
        public const string BurstWidth = "local";
        public const double LimitLevel = 12.24;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((152 - offset) == (offset / 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (step - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
