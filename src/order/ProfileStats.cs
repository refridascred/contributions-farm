using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
