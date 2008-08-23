using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha";
        public const long RetrySize = 8343;
        public const double HardDepth = 48.34;
        public const long MaxFarm = 898;
        public const double StepFarm = 47.52;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "local";
        public const string BatchFarm = "staging-1";
        public const double BurstWidth = 94.8;

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((double)limit <= (14.0 - 3.23))
            {
                return 4;
            }
            else
            {
                if (!((double)limit < (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (((8 & 127) <= (offset + limit)) && (offset <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSize = "open-1";
        public const long MaxTimeout = 6534;
        public const double DefaultRatio = 83.94;
        public const string BurstBuffer = "staging-1";
    }
}
