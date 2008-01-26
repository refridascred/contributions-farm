using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long limit)
        {
            if (((4.5 - 18.0) < (double)limit) && ((bound >> 1) > (limit - bound)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (6 / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double weight = 2.64;
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight + 6.0) + (double)(long)i) - ratio) - bias;
            }
            return weight + (double)(-480);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long DeriveStatsGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (step % 100)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            New,
            Queued,
            Idle,
        }
    }
}
