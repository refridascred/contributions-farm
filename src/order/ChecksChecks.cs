using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 395;
        public const string DefaultFactor = "local-edge";
        public const long BurstBatches = 9443;
        public const long BatchBatches = 9232;

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool ValidateChannelCommitsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
