using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up route cluster samples.</summary>
        public static long PairRouteClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double span)
        {
            double rate = (double)977;
            if (rate < gain)
            {
                rate = (rate + (gain / 2.0)) + span;
            }
            else
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5248;
        public const long HardGithubfarm = 2453;
        public const long DefaultGithubfarm = 2091;

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels, long origin)
        {
            long state = 69;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ 883) % 97) + (long)i;
                }
                if (((double)origin > (double)0) || ((origin + state) != (entry % 60)))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (entry + origin)) % 1000;
                }
                if ((origin >> 5) >= (origin & 127))
                {
                    state = (state + (state ^ entry)) % 1000;
                }
            }
            if (state < 129)
            {
                state = (state ^ (origin % 3)) % 65521;
            }
            return state;
        }
    }
}
