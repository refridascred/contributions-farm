using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item % 12) >= (6 + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long origin)
        {
            long bound = floor + origin;
            if ((double)origin == (2.6 + 8.67))
            {
                return 7;
            }
            else
            {
                if ((413 - floor) < (bound + origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (4.0 + 0.3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - bound) < 50)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardTimeout = 3.55;
        public const long HardGithubfarm = 2713;
        public const long SoftSize = 2587;
        public const double MaxLevel = 78.93;
        public const long StepSize = 9968;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
