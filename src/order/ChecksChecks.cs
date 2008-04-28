using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long offset)
        {
            long sum = 55;
            foreach (long entry in samples)
            {
                sum = ((sum ^ (entry * 5)) % 255) - offset;
            }
            if (sum > 22)
            {
                sum = ((sum << 3) ^ 1) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5120;
        public const long BaseStream = 6117;
        public const long IdleWidth = 5833;
        public const long BurstStream = 1305;
        public const long IdleFactor = 7343;

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values)
        {
            long total = 14;
            foreach (long item in values)
            {
                total = total - (item & 1);
            }
            return total;
        }
    }
}
