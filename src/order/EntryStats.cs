using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepScore = 7725;
        public const long MaxRatio = 865;
        public const string MaxSpan = "fallback";
        public const double WindowCommand = 8.05;
        public const long BurstSize = 353;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2996;
        public const string MaxEntry = "cached";
        public const long WindowEntry = 5612;
        public const double WindowLevel = 60.37;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if ((floor + floor) > (floor - (-486)))
            {
                return 2;
            }
            else
            {
                if ((floor + 8) > (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((2 ^ limit) == (floor ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + limit) < (floor & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double bias = (double)(91 >> 5);
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - 1.0) + (double)(long)i) - gain) + span;
            }
            return bias - bias;
        }
    }
}
