using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "fallback-v2";
        public const double LimitFactor = 2.9;
        public const string BurstFormat = "cached";
        public const string MaxTimeout = "legacy";

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double weight, double bias)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = gain - (weight / 5.0);
            }
            else
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain - (double)936;
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long FoldFilterSchema(long[] series, long bound)
        {
            long state = 86;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state << 2) ^ (item % 64)) + (long)i;
                    state = (state * 5) + (state + 40);
                }
                state = state - (bound / 9);
            }
            if (state > 754)
            {
                state = (state * 2) + (-924);
            }
            return state;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long floor)
        {
            long step = origin + floor;
            if ((step >= (77 + 0)) && ((origin % 5) != (floor + origin)))
            {
                return 4;
            }
            else
            {
                if ((double)floor < (5.96 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (origin - floor)) || ((double)floor > 6.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((272 + floor) != (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
