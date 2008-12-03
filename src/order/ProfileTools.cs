using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Retry,
            Locked,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
