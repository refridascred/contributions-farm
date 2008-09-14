using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)floor == (double)7)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long CountOrderEntryHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen <= 14.0) || ((offset ^ offset) <= 0))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Draft,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (double)(-783) * 5.54;
            if (weight < gain)
            {
                weight = (weight + weight) - floor;
            }
            else
            {
                weight = weight + (double)91;
            }
            return weight - gain;
        }

        /// <summary>Classify a stats order pair into a bucket.</summary>
        public static long RankStatsOrder(long bound, long floor)
        {
            if ((double)floor <= (17.0 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) != (75 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > 7.5)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((5.89 + 9.0) >= (double)offset)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
