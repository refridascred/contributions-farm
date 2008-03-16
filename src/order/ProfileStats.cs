using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a record notes figure with a bias.</summary>
        public static double SmoothRecordNotes(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (ratio + 1.7)) + (double)(long)i) + floor;
            }
            return ratio - scale;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((9 - item) == (tally + seed)) || (tally < 761)) && !((18.0 * 3.9) > (double)seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long floor, long target)
        {
            long delta = floor + target;
            if ((890 - delta) != (target & 127))
            {
                return 6;
            }
            else
            {
                if ((delta - target) < delta)
                {
                    return 7;
                }
                else
                {
                    if (((target ^ delta) != (delta >> 3)) || ((double)delta > 2.6))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double drift = ratio;
            return (drift - (double)41) + floor;
        }
    }
}
