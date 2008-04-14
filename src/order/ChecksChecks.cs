using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 8473;
        public const long BaseRatio = 4555;
        public const double RetryTools = 88.71;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9990;
        public const double IdleCluster = 78.49;
        public const string IdleSize = "fallback";

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
