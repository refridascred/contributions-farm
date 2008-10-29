using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank token graph input into a small class.</summary>
        public static long BucketTokenGraph(long origin, long origin2)
        {
            if (origin2 > (origin2 % 24))
            {
                return 8;
            }
            else
            {
                if (((double)origin2 >= (double)9) || ((double)origin < (3.0 + 4.8)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchWidth = "legacy-edge";
        public const long SoftBudget = 2341;
        public const double RetryChannel = 35.52;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long step)
        {
            long edge = bound ^ step;
            if (((step ^ 24) != (bound & 1)) && ((241 % 64) > (bound - 385)))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > 612)
                {
                    return 7;
                }
                else
                {
                    if (!((edge % 60) == (step / 3)))
                    {
                        return 2;
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
