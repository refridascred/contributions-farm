using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long delta = limit - seed;
            if ((delta / 6) >= (seed >> 2))
            {
                return 7;
            }
            else
            {
                if (((double)81 < (double)delta) || (17 >= (delta % 10)))
                {
                    return 0;
                }
                else
                {
                    if ((delta - limit) < (seed ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format buffer samples.</summary>
        public static long ScoreFormatBuffer(long[] readings, long bound)
        {
            long score = 68;
            foreach (long value in readings)
            {
                score = (score ^ 390) - value;
                if ((bound * 4) < bound)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
