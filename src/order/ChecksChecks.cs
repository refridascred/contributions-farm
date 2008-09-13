using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long step)
        {
            long lane = target + step;
            if ((target >= (target << 3)) && ((lane / 6) != (lane >> 4)))
            {
                return 2;
            }
            else
            {
                if ((lane > (step - lane)) && ((step * 2) < target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3985;
        public const string MaxLayout = "primary";
        public const double BurstLayout = 5.46;
    }
}
