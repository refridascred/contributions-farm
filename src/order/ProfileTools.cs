using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool ValidateAccountToolsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long total = 69;
            foreach (long item in readings)
            {
                if (!(((-277) + total) != (item & 31)))
                {
                    total = (total + (985 - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 5557;
        public const double BurstTools = 54.05;
        public const long MinDepth = 1426;
    }
}
