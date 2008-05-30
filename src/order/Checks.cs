using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (227 <= (item ^ offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report filter entries that pass the check.</summary>
        public static long AuditReportFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) == (sample + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings, long limit)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                if ((limit >= ((-458) >> 5)) && ((value & 3) > 63))
                {
                    mix = (mix * 2) + (mix + 220);
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepWidth = "local";
        public const long IdleFactor = 7187;
        public const double IdleGithubfarm = 30.79;
        public const string CacheLevel = "fallback-1";
    }
}
