using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double rate = span;
            if (rate >= (gain * 2.9))
            {
                rate = rate + (gain * 11.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)3) + (double)(long)i;
            }
            return rate + 1.3;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((0.71 * 9.2) == (double)hits) && ((entry >> 3) <= (hits ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Failed,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long mix = 499;
            foreach (long cell in readings)
            {
                if ((seed + seed) > mix)
                {
                    mix = ((mix << 3) ^ 401) % 1000;
                }
                if (!((seed ^ cell) <= 586))
                {
                    break;
                }
            }
            if (mix > 35)
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value + value) == (805 * 2)) && ((4.25 + 7.16) >= (double)(long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
