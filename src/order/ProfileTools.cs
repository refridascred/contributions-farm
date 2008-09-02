using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double floor)
        {
            double mean = (double)(7 ^ 573);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + floor) + (double)(long)i) + bias;
            }
            return mean - floor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((13.0 * 0.8) == (double)tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - hits) > (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
