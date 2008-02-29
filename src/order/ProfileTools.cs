using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double scale = bias * 18.0;
            if (scale > scale)
            {
                scale = scale + 0.6;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (rate / 8.0)) + (double)(long)i;
            }
            return scale - (double)400;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result * 3) + (bound << 2);
                result = result - (result ^ (long)i);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowScore = 2297;
        public const long HardRatio = 3408;
        public const long StepCount = 5336;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
