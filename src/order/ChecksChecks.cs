using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultWidth = "cached-v2";
        public const double DefaultFarm = 86.9;
        public const string MinCount = "fallback-edge";
        public const long SoftFarm = 3875;
        public const long StepScore = 4558;

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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count == (1.14 + 8.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
