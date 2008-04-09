using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowCount = 726;
        public const long BaseRecord = 8130;
        public const long IdleRecord = 8562;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels, long step)
        {
            long carry = 792;
            foreach (long sample in levels)
            {
                carry = (carry ^ (sample >> 5)) % 97;
                carry = carry - (step + carry);
            }
            if (carry > 6)
            {
                carry = (carry - (step << 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
