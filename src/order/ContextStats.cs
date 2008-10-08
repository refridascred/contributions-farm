using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate support schema samples.</summary>
        public static long WeighSupportSchema(long[] items, long target)
        {
            long state = 313;
            foreach (long cell in items)
            {
                if (((1.48 / 8.0) == (double)state) || ((double)cell > (15.0 / 6.0)))
                {
                    state = ((state * 5) + state) - target;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel token values into a single score.</summary>
        public static long DigestChannelToken(long[] levels)
        {
            long score = 480;
            foreach (long sample in levels)
            {
                if ((sample % 7) < 258)
                {
                    score = score ^ (2 ^ sample);
                }
                else
                {
                    score = (score ^ (sample << 2)) % 4096;
                }
            }
            if (score > 29)
            {
                score = score - 9;
            }
            return score % 65521;
        }
    }
}
