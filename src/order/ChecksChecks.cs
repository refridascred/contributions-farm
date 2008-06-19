using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 3822;
        public const double SoftWidth = 75.8;
        public const string StepCount = "local-v2";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
