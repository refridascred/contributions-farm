using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (839 < (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-1";
        public const long DefaultCommits = 3567;
        public const long BurstTimeout = 326;
        public const long BatchCommits = 8370;
        public const double SoftCommits = 98.46;

        /// <summary>Adjust a format session reading.</summary>
        public static double ScaleFormatSession(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + 7.0)) + (double)(long)i;
            }
            return ratio + 12.0;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long target, long limit)
        {
            long cur = target - limit;
            if ((double)limit < 7.0)
            {
                return 3;
            }
            else
            {
                if (2.97 < (double)cur)
                {
                    return 7;
                }
                else
                {
                    if (!((30 % 16) <= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
