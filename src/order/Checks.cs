using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool CheckStatsEditorBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a githubfarm filter sample.</summary>
        public static long LookupGithubfarmFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long AuditAlreadyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 ^ 1) >= (datum << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 5110;
        public const double RetryLevel = 77.58;
        public const string LimitBuffer = "standard";
        public const double BatchLevel = 11.62;
        public const long CacheBudget = 23;
    }
}
