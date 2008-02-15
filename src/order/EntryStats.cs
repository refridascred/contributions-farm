using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowRatio = 5516;
        public const long MaxInterval = 6057;
        public const string LimitLevel = "fallback";

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double mean = floor;
            if (mean > 5.73)
            {
                mean = (mean - (double)47) + ratio;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + floor) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-v2";
        public const long StepBudget = 9240;
        public const long WindowTimeout = 1596;
        public const long BaseCluster = 2369;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double rate2 = (floor * 2.51) - (rate - floor);
            for (int i = 0; i < 6; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((seed + 750) < seed)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
