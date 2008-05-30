using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2659;
        public const double WindowCache = 39.92;
        public const double BurstCache = 92.22;

        /// <summary>Look up the position of a support session sample.</summary>
        public static long LocateSupportSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Ready,
        }
    }
}
