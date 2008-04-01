using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double load = gain;
            if (load > gain)
            {
                load = load + load;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (floor + floor)) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long floor)
        {
            if (step > (2 % 7))
            {
                return 8;
            }
            else
            {
                if ((floor ^ step) >= (869 - floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)bound > (8.0 + 8.8)) || ((5.2 * 1.9) > (double)(long)i)))
                {
                    score = score - bound;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
