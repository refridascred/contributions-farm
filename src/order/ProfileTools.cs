using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "standard-edge";
        public const double CacheRatio = 60.27;
        public const long IdleChannel = 7384;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long origin)
        {
            long next = bound ^ origin;
            if (8 >= bound)
            {
                return 2;
            }
            else
            {
                if ((next % 97) < (368 << 3))
                {
                    return 8;
                }
                else
                {
                    if (((1.4 * 7.0) <= (9.0 * 9.57)) || ((origin % 24) == (bound - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)bound < (double)860))
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((sum < (floor & 3)) && ((floor * 3) >= (sum & 3)))
                {
                    sum = sum ^ (floor >> 1);
                    break;
                }
                sum = sum - entry;
            }
            return sum;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Stale,
            Done,
            Pending,
        }
    }
}
