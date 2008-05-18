using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry window entries.</summary>
        public static long ScoreEntryWindow(long[] data, long step)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = ((acc << 3) ^ (acc * 3)) % 1000;
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc ^ datum) % 97) + (long)i;
                }
                if (16.0 >= (double)step)
                {
                    acc = (acc ^ (datum + datum)) % 4096;
                }
                else
                {
                    acc = acc + (long)data.Length;
                }
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mark = 3;
            foreach (long reading in items)
            {
                mark = ((mark * 5) + (776 % 12)) % 4096;
                mark = mark + (reading + reading);
                if ((reading + reading) < (mark + reading))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (offset + offset))
            {
                rate2 = (rate2 - rate2) - rate;
            }
            else
            {
                rate2 = rate2 + (offset * 5.5);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (rate2 * 12.0);
        }
    }
}
