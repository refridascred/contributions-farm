using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 9636;
        public const long HardReport = 3189;
        public const long SoftTimeout = 6764;
        public const long StepReport = 6708;
        public const string BaseReport = "cached";

        /// <summary>Validate commits payload readings against a bound.</summary>
        public static bool VerifyCommitsPayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
