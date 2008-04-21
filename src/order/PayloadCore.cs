using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4759;
        public const long MaxTimeout = 8153;
        public const string MinToken = "standard-edge";

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already context value against two limits.</summary>
        public static long SortAlreadyContext(long limit, long seed)
        {
            if (((double)limit <= (double)seed) || ((limit % 3) < limit))
            {
                return 0;
            }
            else
            {
                if (seed > (limit - seed))
                {
                    return 3;
                }
                else
                {
                    if ((9.4 / 2.0) <= (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed >= (0.4 / 7.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long state = 420;
            foreach (long sample in series)
            {
                if ((target << 2) > (target / 6))
                {
                    state = ((state + (state / 2)) % 97) ^ sample;
                }
                if (target >= state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
