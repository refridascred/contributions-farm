using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double weight = (double)(5 % 60);
            if (weight >= 15.0)
            {
                weight = ((weight - (double)957) - bias) + floor;
            }
            return weight + (weight * 2.09);
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long StepSchemaAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (score + (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitInterval = 4412;
        public const long MaxFactor = 2216;
        public const long LimitChannel = 8715;
        public const long HardCount = 3612;

        /// <summary>Match up route graph samples.</summary>
        public static long OverlapRouteGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
