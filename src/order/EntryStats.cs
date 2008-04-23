using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate payload window samples.</summary>
        public static long FoldPayloadWindow(long[] readings)
        {
            long total = 0;
            foreach (long item in readings)
            {
                total = (total - (item * 5)) % 4096;
                if ((total > (total >> 3)) || ((total / 7) == (total - item)))
                {
                    total = (total - (11 / 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryBudget = 7610;
        public const long WindowInterval = 2380;
        public const string RetryWidth = "local-1";

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 625;
            foreach (long value in items)
            {
                if (16.0 > (double)value)
                {
                    sum = (sum + (928 / 2)) % 65521;
                }
            }
            if (sum < 3)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((double)value < (13.0 - 5.8))
                {
                    anchor = anchor + (value / 9);
                }
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Done,
            Pending,
            Retry,
        }
    }
}
