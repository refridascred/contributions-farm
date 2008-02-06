using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series, long limit)
        {
            long state = 44;
            foreach (long datum in series)
            {
                state = ((state - (long)series.Length) % 1000) - datum;
                if ((double)state > (double)7)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state - limit;
            }
            return state;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data, long limit)
        {
            long mark = 6;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark - value) + (long)i;
                    mark = mark - mark;
                }
                if ((value + limit) >= mark)
                {
                    mark = (mark << 3) ^ (2 * 4);
                }
                else
                {
                    mark = ((mark << 3) ^ (value - limit)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - count) >= (831 - count))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 4306;
        public const long RetryWidth = 5619;
        public const long SoftChannel = 4801;
    }
}
