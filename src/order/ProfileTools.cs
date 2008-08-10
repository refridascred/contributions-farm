using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Dropped,
            Active,
            Locked,
            Failed,
            Paused,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long seed, long limit)
        {
            if (((8.0 / 4.0) == (double)seed) && ((seed + seed) >= (seed + limit)))
            {
                return 8;
            }
            else
            {
                if (limit < (limit >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 1) > (seed + 243))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((16.0 - 8.6) >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long origin, long bound)
        {
            long lane = origin ^ bound;
            if (origin >= (5 + lane))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
