using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Ready,
            Draft,
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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (result & 15)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
