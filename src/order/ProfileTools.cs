using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 77.89;
        public const string SoftBuffer = "legacy-v2";
        public const long DefaultBuffer = 1751;
        public const string BaseInterval = "alpha";

        /// <summary>Fold a list of order window readings.</summary>
        public static long ScoreOrderWindow(long[] values, long target)
        {
            long state = 222;
            foreach (long value in values)
            {
                state = (state + (state >> 1)) - target;
                if (!((value * 2) > state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first context filter entry that matches the target.</summary>
        public static long LookupContextFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "legacy-edge";
        public const long BaseScore = 9921;
        public const long HardEntry = 2907;
        public const long HardBudget = 5847;
        public const string DefaultEntry = "latest-edge";

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
