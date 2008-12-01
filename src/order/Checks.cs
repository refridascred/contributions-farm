using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally * 4) <= tally)
                {
                    tally = ((tally + 1) - cell) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8232;
        public const long BurstFactor = 9378;
        public const string MinScore = "cached-v2";

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long floor)
        {
            if ((floor < (step + step)) && ((step * 3) >= ((-34) - step)))
            {
                return 4;
            }
            else
            {
                if ((double)step < (17.0 + 4.2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const double MinTimeout = 57.08;
        public const string StepDepth = "cached-1";
        public const double MinGithubfarm = 70.92;
        public const long BatchDepth = 9808;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double rate = weight;
            if (rate >= (rate + 4.67))
            {
                rate = (rate - rate) + span;
            }
            else
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 11.0) + (double)(long)i;
            }
            return rate - (rate - 4.1);
        }
    }
}
