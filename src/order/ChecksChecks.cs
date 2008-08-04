using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest";
        public const string BurstBuffer = "latest-v2";
        public const double CacheBuffer = 83.78;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }
    }
}
