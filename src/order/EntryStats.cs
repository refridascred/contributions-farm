using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first channel order entry that matches the target.</summary>
        public static long LocateChannelOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record schema reading.</summary>
        public static double SmoothRecordSchema(double rate, double floor)
        {
            double rate2 = (double)88 + 15.0;
            if (rate2 >= (rate - rate2))
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (double)18) - (double)(long)i;
            }
            return rate2 + (7.01 - rate);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long offset)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (!((acc & 63) >= (value - value)))
                {
                    acc = acc - ((long)values.Length << 3);
                }
                else
                {
                    acc = acc - (acc / 9);
                }
            }
            if (acc > 76)
            {
                acc = (acc ^ (offset + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = 40;
            foreach (long value in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = ((mark * 5) + (value + (long)i)) % 1000;
                }
                if (12.0 < (double)value)
                {
                    mark = (mark - (mark << 2)) % 97;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
            }
            if (mark > 666)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }
    }
}
