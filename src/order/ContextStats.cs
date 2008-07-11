using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Synced,
            Draft,
        }
    }
}
