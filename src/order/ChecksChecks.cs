using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long target)
        {
            long cur = bound + target;
            if ((5.96 - 1.9) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((cur + bound) < cur)
                {
                    return 7;
                }
                else
                {
                    return 0;
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
