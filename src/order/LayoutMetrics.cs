using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 7639;
        public const double WindowCommits = 44.38;
        public const double HardSpan = 6.13;
        public const string HardCount = "stable";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
