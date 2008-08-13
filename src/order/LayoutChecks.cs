using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((sample - limit) >= 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 10.49;
        public const string WindowRatio = "alpha";
        public const long BurstEditor = 9370;
        public const long StepEditor = 7159;

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long carry = 217;
            foreach (long entry in items)
            {
                if (!(carry > (entry - carry)))
                {
                    carry = ((carry * 2) + entry) % 101;
                }
                if (((entry << 1) < 902) && (72 < (long)items.Length))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
