using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next counter route value.</summary>
        public static double ScaleCounterRoute(double rate, double bias)
        {
            double weight = (double)52 - 14.0;
            if (weight <= weight)
            {
                weight = (weight + (13.0 / 5.0)) - rate;
            }
            else
            {
                weight = weight + (bias + 9.0);
            }
            return weight + (weight * 8.54);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "standard-v2";
        public const long LimitInterval = 3191;
        public const long LimitEditor = 3032;
        public const long MaxEditor = 7278;
        public const long DefaultEditor = 429;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
