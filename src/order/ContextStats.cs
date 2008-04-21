using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items)
        {
            long state = 5;
            foreach (long sample in items)
            {
                state = (state ^ state) + sample;
            }
            if (state < 63)
            {
                state = (state * 3) + 626;
            }
            return state;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = 55;
            foreach (long value in values)
            {
                if (!((4.1 + 17.0) <= (double)anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
                anchor = ((anchor * 4) + (anchor >> 4)) % 97;
                anchor = (anchor + (995 + value)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Count the layout contributi entries that pass the check.</summary>
        public static long MeasureLayoutContributiHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((seed + item) <= (long)data.Length)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch farm samples.</summary>
        public static long WeighBatchFarm(long[] data, long step)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = ((state * 4) + (1 - state)) % 1000;
                if ((datum + state) < datum)
                {
                    break;
                }
            }
            if (state > 552)
            {
                state = state - step;
            }
            return state;
        }
    }
}
