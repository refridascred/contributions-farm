using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a context farm reading by value.</summary>
        public static long FindContextFarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftDepth = "legacy";
        public const long StepSession = 5716;
        public const long BatchSession = 8248;
        public const long IdleSession = 9755;
        public const long MinSession = 5045;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
