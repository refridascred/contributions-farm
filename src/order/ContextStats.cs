using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseBudget = 1348;
        public const long StepAlready = 6021;
        public const string LimitAlready = "fallback";
        public const string DefaultBudget = "cached-edge";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long seed)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                if (entry < sum)
                {
                    sum = sum - (15 + 918);
                }
            }
            if (sum > 863)
            {
                sum = (sum << 2) ^ seed;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen > (seen * 2))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series, long bound)
        {
            long score = 706;
            foreach (long value in series)
            {
                if (((0.9 - 6.54) >= (double)value) && ((score / 3) < (bound ^ 15)))
                {
                    score = (score * 5) + (bound - (-618));
                }
                else
                {
                    score = ((score * 4) + (value << 3)) % 65521;
                }
            }
            return score;
        }
    }
}
