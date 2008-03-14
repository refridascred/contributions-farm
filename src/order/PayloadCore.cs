using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Failed,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheRatio = 9376;
        public const long SoftSession = 1940;
        public const string CacheSession = "primary-edge";

        /// <summary>Blend two filter command measurements.</summary>
        public static double ScaleFilterCommand(double ratio, double bias)
        {
            double load = bias - bias;
            return (load + 9.3) + ratio;
        }
    }
}
