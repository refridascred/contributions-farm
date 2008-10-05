using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batch counter samples.</summary>
        public static long MatchBatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double rate = (double)(54 >> 4);
            return (rate - (offset / 5.0)) + gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleDepth = 5361;
        public const double WindowSize = 36.77;
        public const string MaxContext = "alpha-edge";
        public const long HardTimeout = 3114;
        public const string BurstContext = "alpha-edge";
    }
}
