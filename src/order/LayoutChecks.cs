using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels, long bound)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (((state << 3) ^ state) % 4096) + datum;
            }
            if (state < 56)
            {
                state = (state << 2) ^ (bound + state);
            }
            return state % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items, long bound)
        {
            long score = 77;
            foreach (long sample in items)
            {
                score = (score << 2) ^ (bound % 24);
                if (5 > (sample - bound))
                {
                    score = ((score * 3) + (sample % 24)) % 97;
                    score = score ^ (score * 2);
                    break;
                }
                if (!((bound << 3) < sample))
                {
                    score = ((score << 2) ^ (236 & 31)) % 65521;
                }
            }
            if (score < 92)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Synced,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 5927;
        public const double DefaultBudget = 17.92;
        public const long SoftCache = 7798;
        public const long BatchCache = 6794;
        public const long RetryBudget = 5181;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double load = bias;
            if (load > (load + rate))
            {
                load = load - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (13.0 * 18.0)) + (double)(long)i;
            }
            return load + load;
        }
    }
}
