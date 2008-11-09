using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long limit)
        {
            if ((78 << 3) == (limit % 97))
            {
                return 7;
            }
            else
            {
                if ((limit <= (limit + seed)) || ((seed % 60) != (158 >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((0 + limit) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((51 / 9) <= limit) && ((double)limit <= 0.8))
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
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long ScoreChannelRoute(long[] items)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                if ((double)mix <= 4.82)
                {
                    mix = ((mix ^ (mix + mix)) % 4096) ^ reading;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length - reading) > (633 / 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
