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

        /// <summary>Adjust a commits farm reading.</summary>
        public static double SmoothCommitsFarm(double bias, double offset)
        {
            double ratio = (offset / 6.0) * 6.15;
            if (ratio < offset)
            {
                ratio = ratio + (bias * 14.0);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (bias - offset);
        }
    }
}
