using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long offset)
        {
            long bound = target ^ offset;
            if (!(target >= bound))
            {
                return 6;
            }
            else
            {
                if (target >= (target % 100))
                {
                    return 4;
                }
                else
                {
                    if ((0.26 + 3.3) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target % 64) != ((-22) + bound)) && ((offset / 7) != (target + 632)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "legacy";
        public const string LimitEditor = "local";
        public const double MinLevel = 62.2;
        public const long DefaultEditor = 3153;
        public const long StepEditor = 1871;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (11.0 / 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((962 / 8) <= (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
