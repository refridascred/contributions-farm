using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double offset)
        {
            double load = offset;
            if (load < offset)
            {
                load = (load + 4.0) - scale;
            }
            return load + (load - load);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1564;
        public const double HardCounter = 4.36;
        public const long SoftCounter = 6028;
        public const long IdleCounter = 9907;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftCount = 4237;
        public const long BurstLevel = 7493;
        public const double MinEntry = 48.7;
        public const long MinSpan = 8600;
        public const long HardEntry = 6156;
    }
}
