using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats order entries that pass the check.</summary>
        public static long MeasureStatsOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((tally > (tally ^ tally)) && ((value + tally) < tally)) || ((tally * 4) != (value << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long sum = 35;
            foreach (long value in data)
            {
                sum = (sum - value) % 97;
            }
            if (sum > 219)
            {
                sum = ((sum * 4) + ((-176) >> 1)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double scale = (double)(53 ^ 712);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - bias) + (double)(long)i) + span;
            }
            return scale + (double)5;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
