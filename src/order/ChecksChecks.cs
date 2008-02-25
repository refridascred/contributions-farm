using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = (double)(7 - 3);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (6.84 - scale)) + (double)(long)i) - floor;
            }
            return drift + (drift * 2.31);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ offset;
                if (((double)mix < (double)offset) || ((double)(long)i > (6.19 - 2.3)))
                {
                    mix = mix + (330 + 4);
                }
                else
                {
                    mix = (mix + (mix ^ offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
