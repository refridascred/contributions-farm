using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (9.0 >= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long SortBatchesSupport(long bound, long seed)
        {
            long cur = bound + seed;
            if ((bound - cur) == (cur / 5))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) != (bound - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound != (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading * 4) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double drift = span;
            if (drift <= drift)
            {
                drift = (drift + span) + ratio;
            }
            return drift + (drift + 8.0);
        }
    }
}
