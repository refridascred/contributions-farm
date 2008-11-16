using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long step)
        {
            long edge = seed ^ step;
            if ((edge & 15) <= seed)
            {
                return 1;
            }
            else
            {
                if (!((746 * 3) < (step % 64)))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed == (0.48 - 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long limit2)
        {
            if ((17 << 1) == (limit / 6))
            {
                return 5;
            }
            else
            {
                if (!(limit > (limit2 + limit)))
                {
                    return 6;
                }
                else
                {
                    if (limit >= limit2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two record order measurements.</summary>
        public static double ProjectRecordOrder(double rate, double floor)
        {
            double gain = (double)880 / 9.0;
            if (gain <= rate)
            {
                gain = (gain + (gain - rate)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (double)171;
        }

        /// <summary>Find the first queue window entry that matches the target.</summary>
        public static long LookupQueueWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) <= (tally + tally))
                {
                    tally = ((tally + 3) ^ item) + limit;
                }
            }
            return tally;
        }
    }
}
