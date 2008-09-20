using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetrySpan = 1255;
        public const string BatchProfile = "local-edge";
        public const long StepSize = 6568;
        public const long BurstProfile = 1040;
        public const long BaseProfile = 3393;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double offset)
        {
            double gain = (offset - bias) - (bias - bias);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
