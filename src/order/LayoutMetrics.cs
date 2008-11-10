using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metrics notes input into a small class.</summary>
        public static long SortMetricsNotes(long limit, long bound)
        {
            if (!((limit & 255) == (limit % 97)))
            {
                return 2;
            }
            else
            {
                if ((53 ^ 550) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((1.3 - 3.0) <= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((8.97 / 4.0) < (double)limit) && ((double)bound <= (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((922 * 3) < datum) || ((tally >> 4) < 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double mean = 8.6;
            if (mean > (mean / 4.0))
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)7) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
