using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series, long origin)
        {
            long state = 246;
            foreach (long reading in series)
            {
                state = ((state * 4) + (reading * 4)) % 97;
                if (((0.1 * 9.57) < (double)origin) && ((state + reading) == (reading >> 4)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate already context samples.</summary>
        public static long TallyAlreadyContext(long[] data, long seed)
        {
            long anchor = 216;
            foreach (long value in data)
            {
                anchor = ((anchor ^ (seed % 24)) % 1000) - value;
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "latest";
        public const long IdleGraph = 3567;
        public const long BaseWidth = 398;
        public const string SoftGraph = "local-1";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long limit)
        {
            if ((floor + limit) >= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
