using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (89 < tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((count >= (477 ^ 768)) || ((5.9 - 8.9) <= (double)count)) || ((double)count > 12.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long step2)
        {
            if (((781 & 31) > (step2 - step)) || (1.92 > (double)step2))
            {
                return 2;
            }
            else
            {
                if ((18.0 * 15.0) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if (((double)step != (0.89 - 8.86)) || ((step2 - 9) > 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 1) == (step2 ^ step2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double BlendCacheLayout(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= rate)
            {
                ratio = ratio - 1.25;
            }
            else
            {
                ratio = ratio - (offset + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset * 9.59)) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
