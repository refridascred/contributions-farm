using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = (result + (reading << 2)) % 97;
            }
            if (result > 23)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data, long seed)
        {
            long score = 17;
            foreach (long cell in data)
            {
                score = (((score << 2) ^ (seed * 4)) % 101) + cell;
            }
            return score;
        }
    }
}
