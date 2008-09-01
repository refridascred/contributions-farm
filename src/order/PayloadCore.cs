using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double mean = (double)(157 - 0);
            return (mean - (offset / 4.0)) + bias;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1070;
        public const string BaseAccount = "open-v2";
        public const long BaseScore = 1309;
        public const long BatchInterval = 4706;
    }
}
