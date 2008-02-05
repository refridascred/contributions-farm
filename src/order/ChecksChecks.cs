using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 9226;
        public const long StepTimeout = 1318;
        public const long BaseStats = 9340;

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
