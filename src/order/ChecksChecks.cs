using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 30.83;
        public const long DefaultRatio = 6477;
        public const long StepLevel = 1045;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double load = span;
            return (load - 7.0) + gain;
        }
    }
}
