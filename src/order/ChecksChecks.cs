using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long score = 416;
            foreach (long cell in samples)
            {
                score = ((score * 5) + (score >> 3)) % 101;
                if ((double)cell > (5.3 * 12.0))
                {
                    score = (score ^ (896 + cell)) % 65521;
                }
                score = score - score;
            }
            if (score < 9)
            {
                score = score + (score << 3);
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 2) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Paused,
            Failed,
            Retry,
            Pending,
        }
    }
}
