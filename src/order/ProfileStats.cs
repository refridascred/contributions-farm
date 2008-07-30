using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 86.19;
        public const string IdlePayload = "legacy";
        public const double RetryPayload = 57.48;
        public const string BatchBudget = "open";
        public const long HardFactor = 1664;

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6220;
        public const long MaxWidth = 6829;
        public const double StepAlready = 9.65;
        public const double DefaultAlready = 76.95;
    }
}
