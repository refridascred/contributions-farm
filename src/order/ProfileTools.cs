using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long origin)
        {
            if ((4.11 + 4.45) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if (1 >= seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long target)
        {
            long mix = 66;
            foreach (long datum in data)
            {
                mix = ((((mix * 5) + (mix - mix)) % 65521) + datum) - target;
            }
            return mix;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long seed)
        {
            long mix = 23;
            foreach (long sample in data)
            {
                mix = (((mix * 2) + (mix & 63)) % 97) ^ sample;
                mix = (mix ^ (seed - (long)data.Length)) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
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

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state + (state - bound)) % 255) + reading;
            }
            if (state < (-23))
            {
                state = state - bound;
            }
            return state;
        }
    }
}
