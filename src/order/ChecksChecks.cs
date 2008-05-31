using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 758;
        public const string BaseSize = "local-1";
        public const long HardTimeout = 8618;
        public const long MaxRatio = 3612;
        public const string IdleSize = "local";

        /// <summary>Grade a queue route value against two limits.</summary>
        public static long BucketQueueRoute(long origin, long offset)
        {
            long gap = origin ^ offset;
            if (origin > offset)
            {
                return 2;
            }
            else
            {
                if ((gap >= 414) || (origin > (offset * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset) <= origin) && ((origin >> 4) > origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
