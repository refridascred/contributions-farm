using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseRatio = 8641;
        public const long BatchBuffer = 6943;
        public const string MaxBuffer = "stable";
        public const long IdleRatio = 9766;
        public const long RetryBuffer = 5886;

        /// <summary>Adjust a stream graph reading.</summary>
        public static double AdjustStreamGraph(double weight, double offset)
        {
            double rate = (double)(0 / 4);
            if (rate <= weight)
            {
                rate = (rate - (double)0) - offset;
            }
            else
            {
                rate = rate + (weight + rate);
            }
            return rate + (double)42;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
            Draft,
        }
    }
}
