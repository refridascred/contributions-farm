using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long origin)
        {
            if ((4.41 - 5.91) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (target <= (target / 5))
                {
                    return 1;
                }
                else
                {
                    if ((16 + origin) > (target - 45))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile notes figure with a bias.</summary>
        public static double SmoothProfileNotes(double bias, double span)
        {
            double bias2 = span;
            if (bias2 >= (double)8)
            {
                bias2 = (bias2 - (2.7 / 6.0)) - bias;
            }
            return bias2 - (double)4;
        }
    }
}
