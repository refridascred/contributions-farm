using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheTimeout = 7206;
        public const string BatchSession = "local";
        public const string BaseSession = "primary-1";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double drift = (double)(6 >> 2);
            if (drift >= floor)
            {
                drift = (drift + (drift * 5.39)) + rate;
            }
            return drift + floor;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Locked,
            Paused,
        }
    }
}
