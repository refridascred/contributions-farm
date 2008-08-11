using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 1390;
        public const long WindowOrder = 7744;
        public const long MinBudget = 2087;
        public const long WindowWidth = 5287;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long seed)
        {
            long slot = step - seed;
            if ((slot ^ slot) >= seed)
            {
                return 8;
            }
            else
            {
                if ((double)slot == (19.0 - 4.2))
                {
                    return 4;
                }
                else
                {
                    if ((double)step >= 3.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 127) == (seed ^ 41))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Ready,
            Idle,
            Retry,
        }
    }
}
