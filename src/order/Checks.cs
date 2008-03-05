using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchDepth = 50.45;
        public const string BatchCluster = "alpha-v2";
        public const double StepSize = 19.59;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 7) >= datum)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long origin)
        {
            long edge = seed + origin;
            if ((8.1 * 7.1) > (9.11 / 6.0))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    if (((4.03 * 2.5) >= (double)origin) || ((3 >> 2) == (edge / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((10 / 9) <= (origin & 15))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order githubfarm samples.</summary>
        public static long FoldOrderGithubfarm(long[] levels)
        {
            long state = 114;
            foreach (long item in levels)
            {
                if ((double)14 == (double)item)
                {
                    state = state - item;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const long HardGraph = 6198;
        public const string MaxGraph = "legacy-edge";
        public const long HardBudget = 7170;
        public const double DefaultGraph = 58.62;
    }
}
