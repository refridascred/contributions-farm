using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long MeasureContextRouteMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor & 31) <= (matches ^ matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                if ((sample - score) >= (score - sample))
                {
                    score = (score + sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double mean = 4.3;
            if (mean >= (scale / 5.0))
            {
                mean = mean - 1.4;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4129;
        public const string MinInterval = "cached-1";
        public const long BatchBudget = 8194;
        public const long RetryPayload = 8480;
        public const double BurstPayload = 57.87;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            Synced,
            Active,
            Closed,
        }
    }
}
