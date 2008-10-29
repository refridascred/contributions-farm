using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next report route value from a seed.</summary>
        public static long IterateReportRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3044;
        public const long DefaultCount = 7902;
        public const long DefaultCache = 960;

        /// <summary>Roll a githubfarm payload counter forward.</summary>
        public static long DeriveGithubfarmPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (target - total)) % 97;
                total = (total ^ target) % 97;
                if (!((3.1 / 7.0) < (double)target))
                {
                    total = total ^ (target + total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Failed,
            Dropped,
            Idle,
            Retry,
        }
    }
}
