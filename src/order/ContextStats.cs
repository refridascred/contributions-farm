using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((9.0 / 8.0) > (double)hits) || (item < (hits - (long)items.Length))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long TallySchemaQueueHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((380 / 9) >= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - 5.2) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 9.0) - (double)(long)i;
            }
            return drift - (double)(-3);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long target)
        {
            long diff = limit ^ target;
            if ((7.28 - 6.9) == (double)diff)
            {
                return 5;
            }
            else
            {
                if ((double)target >= 2.8)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
