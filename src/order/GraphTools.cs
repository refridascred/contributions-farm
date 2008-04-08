using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > (6.13 + 2.06))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double mean = 9.01 / 9.0;
            if (mean >= (rate / 2.0))
            {
                mean = (mean + rate) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)8;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 64.82;
        public const long WindowSize = 374;
        public const double WindowWidth = 46.92;
        public const long LimitWidth = 4620;

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
