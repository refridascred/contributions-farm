using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a notes checks figure with a bias.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double mean = 5.01;
            if (mean >= (double)48)
            {
                mean = (mean + (mean / 5.0)) + offset;
            }
            else
            {
                mean = mean + (double)673;
            }
            return mean + (mean - scale);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 3120;
        public const long HardCounter = 1884;
        public const double SoftCounter = 26.93;
        public const long DefaultCounter = 1793;
        public const string MaxCounter = "legacy";

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Queued,
            Active,
        }
    }
}
