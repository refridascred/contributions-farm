using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every counter checks entry stays within the limit.</summary>
        public static bool ValidateCounterChecksLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Locked,
            Pending,
            Active,
            Retry,
        }
    }
}
