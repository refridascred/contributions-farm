using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long state = 37;
            foreach (long datum in levels)
            {
                if ((3.0 / 5.0) < (double)datum)
                {
                    state = ((state << 3) ^ (state & 7)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (state / 3);
                }
            }
            if (state < 58)
            {
                state = (state - (long)levels.Length) % 97;
            }
            return state % 65521;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound2 / 6) <= bound2)
            {
                return 3;
            }
            else
            {
                if ((double)bound2 >= (7.05 - 7.61))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 63) > (bound2 * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 3610;
        public const double CacheScore = 65.08;
        public const long BatchProfile = 6801;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Closed,
            Done,
            New,
        }
    }
}
