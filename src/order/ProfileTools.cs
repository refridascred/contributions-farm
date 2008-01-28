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

        /// <summary>Combine order profile values into a single score.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long mark = 823;
            foreach (long reading in samples)
            {
                if ((double)reading < (0.8 + 11.0))
                {
                    mark = ((mark * 2) + (mark >> 3)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ 575;
                }
                mark = mark - mark;
            }
            if (mark > 69)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 65521;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long DigestChecksPayload(long[] data, long offset)
        {
            long state = 795;
            foreach (long item in data)
            {
                if ((item >= (853 + offset)) && (offset <= (182 + state)))
                {
                    state = state ^ offset;
                }
            }
            if (state > 571)
            {
                state = (state * 5) + (state + offset);
            }
            return state % 1000;
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
