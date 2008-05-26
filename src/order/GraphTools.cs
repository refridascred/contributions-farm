using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items, long origin)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                anchor = (anchor << 2) ^ (anchor - item);
            }
            if (anchor > 116)
            {
                anchor = ((anchor * 2) + (origin % 16)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleInterval = "staging-v2";
        public const long RetryDepth = 4088;
        public const double MinSupport = 39.16;
        public const long SoftSupport = 573;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Draft,
            Paused,
            Failed,
            Synced,
        }
    }
}
