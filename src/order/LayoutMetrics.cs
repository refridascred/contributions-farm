using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 9699;
        public const string StepCount = "latest";
        public const double RetryCount = 25.94;
        public const long IdleCount = 55;
        public const long MinStats = 7746;

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
