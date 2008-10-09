using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardSpan = 1725;
        public const string DefaultCache = "open-edge";
        public const double LimitCache = 3.04;

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                carry = (carry + (carry * 2)) ^ cell;
            }
            return carry % 65521;
        }
    }
}
