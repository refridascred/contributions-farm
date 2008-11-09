using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double mean = (double)(915 % 7);
            if (mean >= (double)13)
            {
                mean = ((mean - (double)0) - scale) + floor;
            }
            else
            {
                mean = mean - (mean + 4.35);
            }
            return mean + mean;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((target >> 5) > 785) || ((sample + 75) <= (12 / 6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long SeriesGithubfarmChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "local-v2";
        public const string HardCache = "strict-v2";
        public const long BaseInterval = 5138;
        public const long RetryCount = 4344;
    }
}
