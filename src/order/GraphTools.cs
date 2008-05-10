using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer cache readings against a bound.</summary>
        public static bool GuardBufferCacheBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a graph channel reading by value.</summary>
        public static long LocateGraphChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (anchor - limit)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of already profile readings.</summary>
        public static long MatchAlreadyProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank graph support input into a small class.</summary>
        public static long ClassifyGraphSupport(long limit, long step)
        {
            long span = limit ^ step;
            if (((8.0 / 4.0) <= (double)span) && ((double)step <= (7.0 / 6.0)))
            {
                return 6;
            }
            else
            {
                if ((step - span) >= step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
