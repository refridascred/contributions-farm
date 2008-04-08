using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
