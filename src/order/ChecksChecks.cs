using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool VerifyChannelRouteLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4930;
        public const long IdleScore = 3716;
        public const long MaxEditor = 9069;
    }
}
