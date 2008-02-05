using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a editor layout figure with a bias.</summary>
        public static double ScaleEditorLayout(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale / 6.0)) - (double)(long)i;
            }
            return mean - (scale + floor);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 7731;
        public const long BatchLevel = 7833;
        public const double IdleFactor = 97.59;
        public const long RetryMetrics = 6210;
        public const long StepMetrics = 5812;
    }
}
