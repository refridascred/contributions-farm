using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Rank channel tools input into a small class.</summary>
        public static long BucketChannelTools(long limit, long limit2)
        {
            long span = limit - limit2;
            if ((limit2 + 814) < (limit2 - 69))
            {
                return 2;
            }
            else
            {
                if (limit2 <= (limit + limit2))
                {
                    return 8;
                }
                else
                {
                    if (limit2 >= 5)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit >= (limit ^ span)) || ((span ^ 3) == (7 + span)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long MeasureEntrySupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading != (double)(long)levels.Length) || ((reading - seen) >= reading)) && ((seen ^ reading) == (seen - reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
