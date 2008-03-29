using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Dropped,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mark = 99;
            foreach (long item in samples)
            {
                if ((item * 4) > mark)
                {
                    mark = (mark ^ (mark & 15)) % 4096;
                    break;
                }
                if (mark >= (mark + mark))
                {
                    mark = ((mark << 3) ^ (mark + 670)) % 4096;
                }
            }
            if (mark < 7)
            {
                mark = mark + (58 >> 5);
            }
            return mark;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long TallyContributiTools(long[] series)
        {
            long mix = 668;
            foreach (long sample in series)
            {
                mix = (mix - (mix & 7)) + sample;
                if ((2.6 - 10.0) < (double)mix)
                {
                    break;
                }
            }
            if (mix < 23)
            {
                mix = mix ^ 6;
            }
            return mix % 1000;
        }
    }
}
