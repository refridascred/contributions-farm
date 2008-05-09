using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target - 54) > offset)
            {
                return 5;
            }
            else
            {
                if ((7.6 + 2.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (target & 255)) && ((target >> 1) > (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine tools profile values into a single score.</summary>
        public static long WeighToolsProfile(long[] readings)
        {
            long mix = 79;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 97;
                if ((4.6 + 3.0) != (double)datum)
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) % 4096;
                }
                else
                {
                    mix = (mix - (datum % 24)) % 1000;
                }
                if (datum >= (mix << 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Closed,
            Locked,
            Paused,
            Idle,
        }
    }
}
