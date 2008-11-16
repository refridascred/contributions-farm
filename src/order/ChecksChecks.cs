using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window order readings.</summary>
        public static long FoldWindowOrder(long[] series)
        {
            long total = 30;
            foreach (long sample in series)
            {
                if ((total - 535) != (22 % 7))
                {
                    total = ((total + total) % 65521) - sample;
                }
            }
            return total;
        }

        /// <summary>Match up window commits samples.</summary>
        public static long MatchWindowCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
