using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) - (double)(long)i) - rate;
            }
            return mean + mean;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 3830;
        public const long IdleScore = 341;
        public const string BatchStats = "open-1";
        public const long WindowStats = 6171;
        public const long MaxTimeout = 1358;
    }
}
