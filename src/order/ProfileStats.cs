using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 4617;
        public const long MaxCommand = 1050;
        public const long WindowCount = 4942;
        public const long MaxCount = 2870;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 4619;
        public const double IdleNotes = 98.67;
        public const double MaxTimeout = 42.4;
        public const string BaseFactor = "standard-1";
        public const long DefaultNotes = 6424;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if (origin >= (origin - step))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < (origin - 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
