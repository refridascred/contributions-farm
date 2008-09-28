using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstScore = "stable";
        public const double MinTimeout = 95.6;
        public const long StepPayload = 7490;

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = (double)4 * 6.82;
            if (ratio > ratio)
            {
                ratio = ratio + (span * 7.0);
            }
            else
            {
                ratio = ratio - (3.5 + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 15.0) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
