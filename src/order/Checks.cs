using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double gain = floor;
            if (gain <= rate)
            {
                gain = gain + (floor + rate);
            }
            else
            {
                gain = gain + (16.0 - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain + gain)) + (double)(long)i;
            }
            return gain + 11.0;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (!((offset & 255) > (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (lane + 79))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((double)limit < (5.6 + 2.95))
            {
                return 6;
            }
            else
            {
                if ((target <= limit) || ((target + 82) == (82 + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target + 0) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
