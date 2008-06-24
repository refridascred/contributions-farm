using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long floor)
        {
            long result = 47;
            foreach (long entry in levels)
            {
                if (!((floor % 97) < (68 >> 3)))
                {
                    result = (((result * 2) + (floor + 0)) % 97) - entry;
                }
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            New,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long step)
        {
            long acc = 48;
            foreach (long cell in values)
            {
                if (step < (cell >> 2))
                {
                    acc = ((acc * 5) + (step - cell)) % 101;
                    continue;
                }
                else
                {
                    acc = acc + (acc + 5);
                    acc = acc - 966;
                }
                acc = acc ^ (acc << 3);
            }
            return acc % 1000;
        }
    }
}
