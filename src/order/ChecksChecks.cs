using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseWidth = 2510;
        public const long IdleLevel = 5502;
        public const long LimitSpan = 3255;
        public const long SoftDepth = 8152;
        public const long BaseRoute = 882;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
