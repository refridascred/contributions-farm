using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
