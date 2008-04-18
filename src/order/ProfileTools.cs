using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double drift = (double)(54 % 16);
            if (drift >= (floor / 9.0))
            {
                drift = (drift - (drift / 3.0)) - ratio;
            }
            return drift - (double)59;
        }

        /// <summary>Combine cache queue values into a single score.</summary>
        public static long CombineCacheQueue(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score ^ (score << 3)) ^ sample;
            }
            if (score > (-3))
            {
                score = ((score * 4) + (score + 17)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstInterval = 4192;
        public const long MaxSpan = 7265;
        public const string WindowQueue = "staging-edge";
        public const long MaxFactor = 4211;
        public const double RetrySpan = 83.09;
    }
}
