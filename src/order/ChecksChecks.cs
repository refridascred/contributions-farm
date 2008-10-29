using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stats report value against two limits.</summary>
        public static long RankStatsReport(long limit, long floor)
        {
            if ((3.93 + 4.8) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((limit % 100) < (limit - 9))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
