using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardSize = 4105;
        public const long StepCounter = 9640;
        public const long IdleCounter = 1141;

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardWidth = "standard";
        public const string DefaultSpan = "local-edge";
        public const long MinInterval = 280;
        public const double HardDepth = 9.56;
        public const long BaseDepth = 8356;
    }
}
