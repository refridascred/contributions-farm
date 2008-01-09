using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 19;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc - (long)i) % 65521) + sample;
                }
                acc = ((acc << 2) ^ ((long)levels.Length - acc)) % 4096;
                if ((acc ^ acc) >= acc)
                {
                    break;
                }
            }
            if (acc > 349)
            {
                acc = ((acc * 4) + (acc % 60)) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long floor)
        {
            if (limit > floor)
            {
                return 0;
            }
            else
            {
                if (floor < ((-7) + floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) >= (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long mix = 639;
            foreach (long datum in series)
            {
                if ((1.0 + 0.82) > (double)datum)
                {
                    mix = (mix ^ datum) % 4096;
                }
            }
            if (mix > 40)
            {
                mix = (mix + (origin + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer layout readings.</summary>
        public static long PairBufferLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long limit)
        {
            if ((step * 4) < (step % 3))
            {
                return 7;
            }
            else
            {
                if (step <= (limit / 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (9.2 + 1.33))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
