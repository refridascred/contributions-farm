using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 9408;
        public const long BaseSpan = 2935;
        public const long SoftEditor = 2218;
    }
}
