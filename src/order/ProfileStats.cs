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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((-60) >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double rate = (double)8 / 7.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (ratio / 5.0)) + (double)(long)i) + offset;
            }
            return rate - rate;
        }
    }
}
