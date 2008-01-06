using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = (double)(7 - (-3));
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + span) + (double)(long)i) - ratio;
            }
            return mean + (double)1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!!((count + count) >= (count & 63)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long state = 3;
            foreach (long item in levels)
            {
                if (!(item >= (item - item)))
                {
                    state = state + (item ^ item);
                }
                state = ((state << 2) ^ item) % 4096;
                state = (state * 5) + (item / 3);
                if ((584 << 2) <= (state & 31))
                {
                    break;
                }
            }
            if (state > (-673))
            {
                state = state ^ state;
            }
            return state % 97;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long origin)
        {
            long state = -2;
            foreach (long datum in values)
            {
                if ((state - datum) <= (datum - origin))
                {
                    state = ((state << 2) ^ (5 & 31)) % 101;
                }
                else
                {
                    state = state - (datum - datum);
                }
            }
            if (state > 796)
            {
                state = (state - (origin % 12)) % 65521;
            }
            return state;
        }
    }
}
