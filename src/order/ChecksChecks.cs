using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long seed)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if ((cell + cell) > 24)
                {
                    result = ((result << 2) ^ ((long)samples.Length & 1)) - seed;
                }
            }
            return result;
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
