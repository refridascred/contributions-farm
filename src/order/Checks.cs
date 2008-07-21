using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (ratio + 6.2)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 3693;
        public const string DefaultScore = "open";
        public const long SoftRecord = 3793;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 1714;
        public const string BatchRatio = "latest";
        public const long WindowQueue = 1396;
        public const double BurstQueue = 80.1;
        public const long StepQueue = 5081;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            long prev = bound - floor;
            if (floor < prev)
            {
                return 4;
            }
            else
            {
                if ((30 ^ 243) >= prev)
                {
                    return 3;
                }
                else
                {
                    if ((1.6 + 3.33) > (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
