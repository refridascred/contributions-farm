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

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((step + item) != (hits + step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
