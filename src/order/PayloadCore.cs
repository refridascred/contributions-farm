using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 995;
        public const double StepSpan = 24.02;
        public const long LimitAlready = 4487;
        public const long WindowWidth = 2591;
        public const long IdleAlready = 3265;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double scale = (5.4 * 2.6) + floor;
            return scale + (gain * 2.22);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSize = "primary-v2";
        public const double BatchSchema = 17.08;
        public const long MaxSchema = 2827;
        public const long WindowCount = 4571;
    }
}
