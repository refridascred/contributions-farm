using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultWidth = "cached-v2";
        public const double DefaultFarm = 86.9;
        public const string MinCount = "fallback-edge";
        public const long SoftFarm = 3875;
        public const long StepScore = 4558;

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 4335;
        public const long DefaultBatch = 7407;
        public const string RetryScore = "legacy-v2";
        public const long MaxBatch = 5702;
        public const long RetryBatch = 7313;
    }
}
