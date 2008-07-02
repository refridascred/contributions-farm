using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long total = 283;
            foreach (long cell in data)
            {
                if ((double)cell == (1.9 / 2.0))
                {
                    total = (total - (165 - total)) - limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the window tools series from a seed.</summary>
        public static long SeriesWindowTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - (mix >> 2);
                if ((double)seed >= (5.6 * 8.0))
                {
                    mix = mix + (mix * 2);
                }
                if (((double)seed < 1.18) || ((seed % 60) == (seed - (long)i)))
                {
                    mix = mix ^ seed;
                }
                else
                {
                    mix = (mix + (mix - seed)) % 1000;
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
