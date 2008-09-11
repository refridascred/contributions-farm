using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleDepth = 8778;
        public const string WindowDepth = "strict-v2";
        public const long MinAlready = 1474;
        public const long DefaultAlready = 7330;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mix = 52;
            foreach (long cell in readings)
            {
                if ((cell << 2) != (795 - cell))
                {
                    mix = ((mix << 2) ^ (mix << 3)) % 255;
                }
                else
                {
                    mix = mix - (cell + mix);
                }
            }
            if (mix < 909)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }
    }
}
