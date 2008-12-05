using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5755;
        public const long MinBudget = 3325;
        public const long LimitCount = 7146;

        /// <summary>Fold a list of window route readings.</summary>
        public static long DigestWindowRoute(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if (state >= (value + value))
                {
                    state = (state + state) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) <= (hits >> 2))
                {
                    hits = ((hits + 1) - datum) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double scale, double offset)
        {
            double rate = scale;
            if (rate > (double)83)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Failed,
            New,
            Locked,
        }
    }
}
