using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 1886;
        public const long MinSpan = 4257;
        public const double BurstBatches = 28.18;
        public const long CacheBatches = 9428;

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double rate, double bias)
        {
            double scale = rate - (rate * 17.0);
            if (scale < (bias * 16.0))
            {
                scale = scale + (scale + scale);
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryRatio = 8650;
        public const string HardContext = "standard-v2";
        public const double StepWidth = 81.71;
        public const long IdleRatio = 7137;
    }
}
