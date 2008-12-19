using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches order samples.</summary>
        public static long DigestBatchesOrder(long[] samples, long seed)
        {
            long mix = 79;
            foreach (long datum in samples)
            {
                if ((5.8 + 0.3) > (double)seed)
                {
                    mix = (((mix << 3) ^ ((-51) & 255)) % 101) - datum;
                }
            }
            return mix;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long MeasureProfileLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((limit + matches) >= 70) && ((limit << 1) <= limit))
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
