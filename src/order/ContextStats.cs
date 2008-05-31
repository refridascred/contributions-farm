using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheSpan = 9221;
        public const long CacheToken = 555;
        public const long StepToken = 1186;

        /// <summary>Count context cluster pairs that satisfy a relation.</summary>
        public static long CompareContextClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if ((origin + origin) < origin)
            {
                return 1;
            }
            else
            {
                if ((origin - origin) < origin)
                {
                    return 2;
                }
                else
                {
                    if (((63 + 17) != (step % 100)) && (origin > (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin >> 2) > (step << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
