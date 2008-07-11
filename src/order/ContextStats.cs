using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Retry,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Audit stream tools readings against a rule.</summary>
        public static long CountStreamToolsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length != (item / 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long RankCommitsGithubfarm(long target, long origin)
        {
            if (((target + target) >= (target ^ target)) || ((double)target < (1.24 - 5.0)))
            {
                return 2;
            }
            else
            {
                if ((target + target) > (origin + target))
                {
                    return 0;
                }
                else
                {
                    if (((703 - origin) >= (origin << 3)) || ((target - target) == (origin % 10)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9.16 + 16.0) >= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool GuardTokenContextRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
