using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long floor)
        {
            if (14.0 < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor - floor) > (-64)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 5678;
        public const double HardReport = 13.2;
        public const string IdleRatio = "fallback";

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double scale, double bias)
        {
            double drift = (double)9;
            if (drift <= 4.1)
            {
                drift = drift + 0.4;
            }
            else
            {
                drift = drift + (bias - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count window payload pairs that satisfy a relation.</summary>
        public static long OverlapWindowPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
