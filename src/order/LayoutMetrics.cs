using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            New,
            Failed,
        }

        /// <summary>Derive the next support profile value from a seed.</summary>
        public static long DeriveSupportProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2839;
        public const long HardPayload = 3843;
        public const long HardWidth = 421;
        public const long BaseSpan = 1406;
        public const double DefaultTimeout = 47.71;
    }
}
