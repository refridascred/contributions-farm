using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Grade a schema session value against two limits.</summary>
        public static long GradeSchemaSession(long limit, long target)
        {
            if (((target + limit) <= 1) || ((target - 879) > (target % 24)))
            {
                return 5;
            }
            else
            {
                if (target > (target >> 2))
                {
                    return 8;
                }
                else
                {
                    if (!((target % 97) != (target % 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3660;
        public const double CacheFactor = 46.51;
        public const string MinLevel = "cached-edge";
    }
}
