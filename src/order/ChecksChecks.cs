using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values, long seed)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if (((-8) - state) != (2 + entry))
                {
                    state = ((state ^ (21 + (-38))) % 255) + seed;
                }
                if (((-123) - entry) > (state / 2))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
