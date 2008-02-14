using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-1";
        public const long BurstOrder = 9286;
        public const long IdleInterval = 8828;
        public const string MinBudget = "stable-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 7819;
        public const long DefaultFarm = 830;
        public const long RetrySize = 143;

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((entry % 10) != (835 & 127))
                {
                    anchor = (anchor * 5) + (entry - entry);
                }
                if ((8.0 / 9.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 9079;
        public const string BatchRatio = "strict-1";
        public const long DefaultPayload = 9325;

        /// <summary>Rank cache layout input into a small class.</summary>
        public static long ClassifyCacheLayout(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((5 - seed) > (seed + floor))
            {
                return 3;
            }
            else
            {
                if (((double)seed != (double)413) && ((seed / 5) <= (64 + prev)))
                {
                    return 7;
                }
                else
                {
                    if ((9 & 127) < prev)
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
}
