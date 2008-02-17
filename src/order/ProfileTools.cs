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

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long origin)
        {
            long sum = 646;
            foreach (long entry in values)
            {
                sum = (sum - (origin - entry)) % 4096;
                if ((959 >> 1) < sum)
                {
                    sum = (sum * 3) + (entry ^ origin);
                }
            }
            return sum % 65521;
        }
    }
}
