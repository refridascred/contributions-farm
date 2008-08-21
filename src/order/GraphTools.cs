using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long limit)
        {
            if ((floor & 255) < (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (floor > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit + 374) <= (floor + 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] items, long step)
        {
            long total = 29;
            foreach (long item in items)
            {
                if (((item & 15) == (step - item)) && ((double)item >= (1.4 / 5.0)))
                {
                    total = ((total << 2) ^ (item << 2)) % 4096;
                }
                else
                {
                    total = total ^ ((-22) + step);
                }
            }
            return total;
        }

        /// <summary>Count command batch pairs that satisfy a relation.</summary>
        public static long CompareCommandBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = ratio;
            if (load > 4.0)
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias + ratio)) - (double)(long)i;
            }
            return load + (5.0 - ratio);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + target) <= target)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
