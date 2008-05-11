using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long CountBatchSchemaOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits >> 4) > limit) && (limit <= (7 + limit)))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double ratio = weight - (18.0 / 5.0);
            if (ratio > 4.3)
            {
                ratio = ratio + (8.0 * 7.8);
            }
            else
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (floor - floor)) + (double)(long)i;
            }
            return ratio + (floor + weight);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value <= (18.0 * 2.0))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long MatchQueueGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
