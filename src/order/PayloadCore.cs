using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a already report figure with a bias.</summary>
        public static double ScaleAlreadyReport(double bias, double bias2)
        {
            double weight = (double)(38 + 106);
            if (weight > (bias2 / 2.0))
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (9.1 + bias2)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = 0.5;
            if (scale < (rate + span))
            {
                scale = scale + rate;
            }
            return scale - (double)99;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 8524;
        public const long DefaultFactor = 2994;
        public const long IdleGithubfarm = 6374;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Queued,
            Failed,
            Draft,
            Pending,
        }
    }
}
