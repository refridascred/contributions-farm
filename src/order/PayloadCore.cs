using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format stats values into a single score.</summary>
        public static long ScoreFormatStats(long[] data)
        {
            long mark = 245;
            foreach (long reading in data)
            {
                double bias = (double)(reading + reading);
                if ((4.76 >= bias) && ((8 - reading) < ((long)data.Length + mark)))
                {
                    mark = (mark + (reading ^ mark)) % 97;
                }
                mark = (mark + (mark + reading)) % 97;
                if (((reading + mark) > (reading - 2)) || ((mark % 100) != (986 + reading)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long limit2)
        {
            if ((limit << 3) > (limit + limit2))
            {
                return 0;
            }
            else
            {
                if ((limit2 >> 1) <= (67 + limit2))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (9.89 - 0.67))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
