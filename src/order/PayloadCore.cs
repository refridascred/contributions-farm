using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultDepth = 3808;
        public const long IdleToken = 9403;
        public const long BatchToken = 6498;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 16.01;
        public const long BatchSize = 5059;
        public const double DefaultEntry = 45.31;
        public const long StepSize = 421;
    }
}
