using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            New,
            Dropped,
            Active,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
