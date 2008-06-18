using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
