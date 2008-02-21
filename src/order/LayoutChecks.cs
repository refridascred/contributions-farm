using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7350;
        public const double SoftScore = 84.23;
        public const double BatchBudget = 61.71;
        public const long MaxRatio = 1208;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5173;
        public const long MinWidth = 3255;
        public const long StepCommand = 9392;
        public const long BurstDepth = 8344;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "open-1";
        public const string DefaultInterval = "cached";
        public const long MaxSpan = 7906;
        public const string WindowGithubfarm = "stable-1";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches << 2) >= (matches + sample)))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
