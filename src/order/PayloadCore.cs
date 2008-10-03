using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a format schema reading.</summary>
        public static double SmoothFormatSchema(double scale, double span)
        {
            double gain = scale;
            if (gain >= (scale - span))
            {
                gain = gain - 5.2;
            }
            else
            {
                gain = gain - (19.0 - gain);
            }
            return gain + 2.39;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 47.76;
        public const string HardBudget = "alpha";
        public const long CacheCommand = 7540;
        public const string HardCommand = "stable-1";
        public const long LimitCommand = 894;

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "latest-edge";
        public const string HardAlready = "legacy-v2";
        public const string StepAlready = "latest-1";
    }
}
