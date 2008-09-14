using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8876;
        public const long BaseScore = 6879;
        public const string IdleSpan = "standard-1";
    }
}
