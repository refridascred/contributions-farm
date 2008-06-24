using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double scale, double offset)
        {
            double bias = 2.0;
            if (bias <= 17.0)
            {
                bias = ((bias + (double)7) - scale) - offset;
            }
            else
            {
                bias = bias - (double)47;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias / 8.0)) + (double)(long)i;
            }
            return bias - (double)31;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)(9 ^ 96);
            if (rate >= (double)0)
            {
                rate = rate - 4.33;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum >= (4 + limit)))
                {
                    sum = sum + ((long)i & 15);
                }
                if (!((3 ^ limit) > (limit + (long)i)))
                {
                    sum = (sum + (limit >> 5)) % 4096;
                }
                else
                {
                    sum = sum ^ (limit - sum);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
