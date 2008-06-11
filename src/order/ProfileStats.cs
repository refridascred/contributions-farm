using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Grade a commits profile value against two limits.</summary>
        public static long RankCommitsProfile(long floor, long offset)
        {
            long delta = floor + offset;
            if ((floor <= (offset % 8)) || (offset >= (delta & 7)))
            {
                return 3;
            }
            else
            {
                if ((0 % 24) < delta)
                {
                    return 5;
                }
                else
                {
                    if (offset > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (9.78 + 9.29))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
