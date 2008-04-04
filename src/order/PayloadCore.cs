using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                long count = (floor & 127) - 6;
                count = (count * 5) + (count + 8);
                state = ((state * 2) + (count / 2)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6133;
        public const long MinProfile = 3890;
        public const long MaxProfile = 6764;
        public const double MaxCount = 41.84;
    }
}
