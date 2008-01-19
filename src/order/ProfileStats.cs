using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "standard-1";
        public const double HardBudget = 63.62;
        public const long RetryLayout = 7492;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 780;
            foreach (long reading in readings)
            {
                if ((189 + result) >= (reading ^ result))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if ((reading + 381) > (result >> 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
