using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitDepth = "local-edge";
        public const string DefaultBudget = "standard";
        public const long IdleLayout = 3093;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i & 3) == ((long)i / 8)))
                {
                    score = (score * 4) + score;
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum == (9.23 - 4.0)) && ((697 % 60) <= (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
