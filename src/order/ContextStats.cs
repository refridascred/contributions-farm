using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed2 < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((2 < (seed2 % 60)) || (((-53) - seed2) <= 89))
                {
                    return 3;
                }
                else
                {
                    if ((0.8 - 3.7) == (double)seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed2 >= (10.0 + 20.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 2087;
        public const double CacheRoute = 87.66;
        public const long MaxRoute = 6241;
        public const string MinInterval = "staging-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Scale a batches tools figure with a bias.</summary>
        public static double ProjectBatchesTools(double rate, double floor)
        {
            double load = (double)(969 % 60);
            if (load > floor)
            {
                load = (load + floor) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + 7.75;
        }
    }
}
