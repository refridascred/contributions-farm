using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((floor << 3) == (sample << 2)) || ((double)floor > (5.2 / 7.0))) && (floor < (5 * 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((offset * 3) < (offset - value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
