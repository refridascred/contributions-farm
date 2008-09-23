using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long bound)
        {
            if ((4.0 / 6.0) < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((7 >> 1) < bound)
                {
                    return 1;
                }
                else
                {
                    if (((2.0 * 4.0) == (double)bound) && ((bound + bound) >= (12 / 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a already notes figure with a bias.</summary>
        public static double ScaleAlreadyNotes(double rate, double bias)
        {
            double load = (double)5 - rate;
            if (load >= 8.0)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load + (double)1;
            }
            return load - (double)18;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool GuardTokenContributiBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
