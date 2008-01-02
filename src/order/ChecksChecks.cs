using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2835;
        public const long SoftChannel = 2912;
        public const long HardChannel = 3815;
        public const long WindowLevel = 1301;
    }
}
