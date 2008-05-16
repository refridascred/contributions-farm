using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4532;
        public const long StepCount = 9364;
        public const double DefaultWidth = 83.85;
        public const double DefaultTimeout = 59.23;
        public const string LimitFactor = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseTimeout = "staging-edge";
        public const long BatchBuffer = 2375;
        public const long BaseCount = 1011;
        public const double BatchRatio = 61.16;
        public const long BurstBuffer = 8841;

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
