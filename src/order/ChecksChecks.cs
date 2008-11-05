using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long step)
        {
            if (((589 + step) < (floor ^ step)) || ((step + 73) == (5 + step)))
            {
                return 7;
            }
            else
            {
                if ((5.0 + 9.7) == (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9 - item) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
