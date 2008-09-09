using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            Synced,
            Closed,
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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((span << 2) != (bound % 2))
            {
                return 4;
            }
            else
            {
                if ((span + span) <= span)
                {
                    return 5;
                }
                else
                {
                    if ((span % 7) >= (span & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if (856 >= (span << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
