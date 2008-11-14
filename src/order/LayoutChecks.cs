using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context cache input into a small class.</summary>
        public static long SortContextCache(long floor, long bound)
        {
            if ((floor + bound) == (floor & 1))
            {
                return 5;
            }
            else
            {
                if (((bound & 63) >= (bound >> 4)) || ((floor - bound) == (60 - bound)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor != (3.3 - 3.48)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((5.4 + 0.11) > (double)bound) || ((double)floor < (5.45 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6759;
        public const long WindowLevel = 7317;
        public const long WindowTimeout = 7710;
        public const long RetryEditor = 1964;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long mark = 49;
            foreach (long cell in items)
            {
                if (((3.4 / 9.0) != (double)cell) || ((mark ^ cell) > mark))
                {
                    mark = (mark + mark) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (mix + (item << 3)) % 65521;
            }
            if (mix < 8)
            {
                mix = ((mix * 4) + (mix + mix)) % 255;
            }
            return mix % 97;
        }
    }
}
