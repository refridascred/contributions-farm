using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = (double)468;
            if (scale <= (double)5)
            {
                scale = (scale - scale) + bias;
            }
            return scale + floor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a tools command counter forward.</summary>
        public static long IterateToolsCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
