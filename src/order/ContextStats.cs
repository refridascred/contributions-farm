using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mark = 666;
            foreach (long cell in readings)
            {
                if (((double)cell < (double)mark) || ((128 ^ mark) <= (791 + 7)))
                {
                    mark = (mark << 3) ^ (cell - (long)readings.Length);
                }
            }
            if (mark > 64)
            {
                mark = (mark * 2) + (348 + mark);
            }
            return mark;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long SortCounterLayout(long step, long origin)
        {
            if ((19.0 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step >> 4) > step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 3) > (origin ^ 749))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
