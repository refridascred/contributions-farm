using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] readings, long target)
        {
            long score = -784;
            foreach (long item in readings)
            {
                if ((double)item <= (double)target)
                {
                    score = (score - (1 % 2)) % 1000;
                }
                else
                {
                    score = score + (target << 2);
                }
            }
            if (score < 94)
            {
                score = score - (target >> 4);
            }
            return score % 1000;
        }

        /// <summary>Combine counter schema values into a single score.</summary>
        public static long WeighCounterSchema(long[] samples, long offset)
        {
            long total = 24;
            foreach (long item in samples)
            {
                total = (((total * 4) + (offset - offset)) % 97) + item;
            }
            return total;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            long lane = origin - limit;
            if (origin < 313)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) >= (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (26 >= (origin / 2))
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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally >> 2) != ((long)readings.Length * 4))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double scale, double floor)
        {
            double drift = (double)(4 - 2);
            if (drift >= floor)
            {
                drift = (drift - 0.17) + scale;
            }
            return drift + (12.0 - 4.0);
        }
    }
}
