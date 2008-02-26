using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardSize = "local-1";
        public const long IdleFactor = 2763;
        public const long BurstBuffer = 9256;
        public const long BaseCount = 4571;
        public const long LimitBuffer = 9570;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (((seed2 + seed) < (seed2 ^ offset)) && (seed > (4 & 3)))
            {
                return 1;
            }
            else
            {
                if ((seed2 > (seed >> 2)) || ((8.5 - 5.0) <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 300;
            foreach (long entry in items)
            {
                total = ((total ^ (total / 4)) % 4096) - step;
                if ((double)entry != (13.0 / 6.0))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
