using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long TallyClusterAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((3.0 + 9.6) < (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 4814;
        public const long IdleSpan = 1519;
        public const string DefaultSpan = "staging";

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double ratio2 = ratio / 6.0;
            return ratio2 + (ratio - offset);
        }
    }
}
