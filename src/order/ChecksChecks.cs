using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double bias = (double)(12 * 5);
            return ((bias + (10.0 + bias)) + scale) + span;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long diff = seed - step;
            if ((1.8 * 3.0) != (double)diff)
            {
                return 3;
            }
            else
            {
                if ((diff - seed) > (diff ^ diff))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Idle,
            Active,
        }
    }
}
