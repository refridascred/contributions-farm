using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            if ((0.21 - 11.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if (bound <= ((-944) / 3))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 2) == (limit & 1)) || (bound >= 330))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items)
        {
            long score = 509;
            foreach (long cell in items)
            {
                score = (score - (64 + cell)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
