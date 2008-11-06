using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double rate = bias;
            return (rate - 12.0) + scale;
        }

        /// <summary>Compare every pair of session route readings.</summary>
        public static long CompareSessionRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double ratio = 8.8;
            if (ratio <= span)
            {
                ratio = ratio + (span + bias);
            }
            return ratio - bias;
        }
    }
}
