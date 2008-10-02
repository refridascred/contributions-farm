using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long offset)
        {
            long mark = 267;
            foreach (long sample in samples)
            {
                if ((double)offset >= (double)mark)
                {
                    mark = (mark - offset) % 65521;
                    mark = mark - (0 + offset);
                }
                mark = ((mark * 2) + (mark ^ sample)) % 65521;
                if ((29 + mark) > (sample * 4))
                {
                    mark = (mark + (sample + offset)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (sample & 127);
                }
            }
            if (mark > 540)
            {
                mark = mark - (offset / 3);
            }
            return mark;
        }

        /// <summary>Fold a list of metric commits readings.</summary>
        public static long FoldMetricCommits(long[] data)
        {
            long state = 691;
            foreach (long datum in data)
            {
                state = (state * 5) + state;
                for (int i = 0; i < 9; i++)
                {
                    state = state ^ state;
                    state = (state ^ ((long)i << 2)) % 1000;
                }
                if (state >= (state - state))
                {
                    state = ((state * 3) + (datum + datum)) % 255;
                }
            }
            if (state < (-5))
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((318 >= (tally & 7)) && ((65 >> 2) > (cell >> 1)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (137 % 24))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
