using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a context payload value against two limits.</summary>
        public static long GradeContextPayload(long origin, long origin2)
        {
            if ((origin - origin) > (4 * 3))
            {
                return 7;
            }
            else
            {
                if ((origin > (origin + 47)) || (origin2 > (24 - origin2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (0.96 / 4.0)) + (double)(long)i) + gain;
            }
            return load + 4.6;
        }
    }
}
