using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 9965;
        public const double WindowFactor = 55.42;
        public const string RetryFarm = "strict-v2";
        public const long BatchCount = 9764;

        /// <summary>Fold a list of filter already readings.</summary>
        public static long CombineFilterAlready(long[] values, long offset)
        {
            long carry = 62;
            foreach (long entry in values)
            {
                carry = ((carry ^ (entry ^ 111)) % 255) - offset;
                carry = (carry ^ (carry / 4)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] values)
        {
            long acc = 67;
            foreach (long cell in values)
            {
                acc = (((acc * 2) + acc) % 1000) + cell;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultLevel = 44.42;
        public const long BurstOrder = 6000;
        public const long DefaultTimeout = 324;
        public const long MaxWidth = 850;
        public const long BaseCount = 8107;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
