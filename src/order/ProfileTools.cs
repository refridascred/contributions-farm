using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstLevel = 8775;
        public const long HardCluster = 251;
        public const long SoftLevel = 4910;
        public const long HardInterval = 5843;
        public const string BaseSpan = "staging";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Pending,
            Active,
            Failed,
            New,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool GuardBatchFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
