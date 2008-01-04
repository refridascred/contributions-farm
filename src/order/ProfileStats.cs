using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool VerifyAccountFilterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target % 10) > target)
                {
                    long tally = state;
                    state = (state << 3) ^ tally;
                }
                else
                {
                    state = (state + (14 + target)) % 255;
                }
                if (9.0 < (double)target)
                {
                    state = state + (long)i;
                }
                else
                {
                    state = (state * 2) + target;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool GuardToolsCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
