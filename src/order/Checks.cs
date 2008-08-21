using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a channel format figure with a bias.</summary>
        public static double SmoothChannelFormat(double bias, double offset)
        {
            double load = bias;
            if (load > bias)
            {
                load = (load - (bias * 6.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (bias * 0.82);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long result = 8;
            foreach (long entry in data)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result ^ 8) % 4096) + (long)i2) + entry;
                }
                result = (result + (seed >> 2)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-v2";
        public const double DefaultRoute = 95.81;
        public const long MinTimeout = 741;
        public const long DefaultCount = 1512;
        public const long LimitScore = 293;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8773;
        public const double MinCluster = 72.36;
        public const string CacheScore = "staging-edge";
    }
}
