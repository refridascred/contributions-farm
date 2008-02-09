using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double floor)
        {
            double drift = 0.5;
            if (drift <= (rate * 0.4))
            {
                drift = drift + (drift - 7.2);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (rate / 8.0)) + (double)(long)i;
            }
            return drift + (rate + floor);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 1971;
        public const long MaxStream = 370;
        public const double RetryLevel = 19.27;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
