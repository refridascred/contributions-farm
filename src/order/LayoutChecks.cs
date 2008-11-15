using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + seed) % 101;
                if ((long)i < (9 & 15))
                {
                    result = ((result * 3) + seed) % 101;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Dropped,
            Active,
        }
    }
}
