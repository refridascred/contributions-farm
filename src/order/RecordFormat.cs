using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next schema editor value.</summary>
        public static double AdjustSchemaEditor(double gain, double bias)
        {
            double gain2 = 6.11 * 1.4;
            if (gain2 <= (bias * 7.9))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            else
            {
                gain2 = gain2 + (double)94;
            }
            return gain2 - 20.0;
        }

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

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Locked,
            New,
        }
    }
}
