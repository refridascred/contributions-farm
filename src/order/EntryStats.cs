using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = (mean + rate) - floor;
            }
            return mean - rate;
        }

        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool GuardMetricChecksLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long SeriesContextRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin == (9.6 * 6.0)))
                {
                    acc = (acc * 2) + acc;
                }
                acc = (acc * 3) + (origin ^ (long)i);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                long seen = sum + target;
                if ((double)target <= 8.0)
                {
                    sum = (sum * 3) + (sum - seen);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool CheckMetricNotesBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
