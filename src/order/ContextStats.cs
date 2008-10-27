using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 48.59;
        public const double HardDepth = 57.19;
        public const long MaxWidth = 3296;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 7070;
        public const double BaseSchema = 67.92;
        public const long HardSchema = 6687;
        public const long BatchSchema = 8860;
        public const string RetrySchema = "strict-v2";

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchInterval = 8043;
        public const string BatchContext = "stable-edge";
        public const long IdleContext = 9608;
        public const long SoftContext = 3163;
    }
}
