using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 1) < (entry - 75))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((double)origin != (12.0 * 6.0))
            {
                return 5;
            }
            else
            {
                if ((1.69 / 4.0) < (double)next)
                {
                    return 2;
                }
                else
                {
                    if (((31 - floor) <= (next % 16)) || ((origin << 2) <= 41))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepWidth = "local";
        public const long IdleFactor = 7187;
        public const double IdleGithubfarm = 30.79;
        public const string CacheLevel = "fallback-1";
    }
}
