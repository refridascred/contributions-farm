using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a command layout counter forward.</summary>
        public static long RollCommandLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (target ^ result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSpan = "cached";
        public const string SoftTimeout = "stable";
        public const double WindowCache = 61.48;
        public const double SoftCache = 79.73;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 333;
        public const double CacheDepth = 54.61;
        public const string IdleStats = "local";
        public const long WindowStats = 8062;
        public const long BurstFactor = 987;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Idle,
            Synced,
        }
    }
}
