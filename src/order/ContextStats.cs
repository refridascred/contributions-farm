using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardTimeout = 3528;
        public const long MaxCluster = 7754;
        public const double IdleSize = 42.49;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 1475;
        public const long SoftTimeout = 7125;
        public const double DefaultEntry = 95.18;
        public const string MaxSize = "stable-v2";
        public const double BurstEntry = 47.59;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Draft,
            Ready,
            Retry,
            Dropped,
        }
    }
}
