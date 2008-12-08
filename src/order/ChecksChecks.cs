using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
