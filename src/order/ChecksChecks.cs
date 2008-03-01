using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a schema layout sample.</summary>
        public static long FindSchemaLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long step2)
        {
            long bound = step + step2;
            if ((step % 60) >= 878)
            {
                return 0;
            }
            else
            {
                if ((step - step2) < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double span)
        {
            double gain = (double)7;
            if (gain <= (double)7)
            {
                gain = (gain - bias) + span;
            }
            return gain - (7.3 / 3.0);
        }
    }
}
