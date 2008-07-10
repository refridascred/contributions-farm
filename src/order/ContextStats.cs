using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((offset / 2) <= (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] samples, long offset)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                mark = (((mark * 2) + 108) % 101) - item;
                if (!((offset / 8) == (3 << 2)))
                {
                    mark = (mark * 5) + (25 / 6);
                }
            }
            if (mark > (-83))
            {
                mark = (mark - (mark & 127)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (floor <= (value & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
