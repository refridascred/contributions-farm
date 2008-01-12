using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowScore = 9467;
        public const string WindowSpan = "standard-v2";
        public const long WindowBudget = 2224;
        public const long SoftInterval = 9353;

        /// <summary>Rank entry filter input into a small class.</summary>
        public static long SortEntryFilter(long target, long bound)
        {
            if ((target + bound) < target)
            {
                return 0;
            }
            else
            {
                if ((target % 10) > bound)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
