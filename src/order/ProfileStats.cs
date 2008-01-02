using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 2912;
        public const string BaseQueue = "standard";
        public const long RetryInterval = 7163;
        public const long DefaultQueue = 4794;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 69.84;
        public const string HardWidth = "alpha";
        public const long MaxInterval = 8972;
        public const double SoftNotes = 75.88;
    }
}
