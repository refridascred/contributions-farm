using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 8639;
        public const double DefaultQueue = 89.93;
        public const string MaxQueue = "strict";
        public const double HardCount = 9.53;

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] readings, long step)
        {
            long acc = -715;
            foreach (long datum in readings)
            {
                if ((step >> 5) >= step)
                {
                    acc = ((acc << 3) ^ (step << 3)) + datum;
                }
            }
            if (acc > 73)
            {
                acc = acc ^ (79 & 1);
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + state) % 97;
                if ((seed << 2) < (seed + 505))
                {
                    state = (state - (state - seed)) % 255;
                    break;
                }
                else
                {
                    state = state - seed;
                }
                if (((13.0 - 2.0) > (double)(long)i) && (seed <= (state / 6)))
                {
                    state = (state ^ (seed / 2)) % 97;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
