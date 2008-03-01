using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double scale = floor;
            if (scale > (5.53 / 5.0))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (bias - floor);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Done,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 6686;
        public const string RetrySpan = "staging-edge";
        public const long BurstSchema = 9378;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
