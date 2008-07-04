using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((-2) <= (value / 2))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9399;
        public const string CacheGithubfarm = "primary";
        public const string DefaultRatio = "primary-v2";
        public const long MaxGithubfarm = 4974;
        public const long WindowGithubfarm = 4868;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long score = 21;
            foreach (long value in levels)
            {
                if ((value - score) >= ((-2) >> 1))
                {
                    score = ((score * 5) + ((-69) / 5)) % 4096;
                }
                score = (score ^ (98 >> 3)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
