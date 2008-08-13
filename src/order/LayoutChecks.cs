using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long step2)
        {
            long slot = step + step2;
            if ((376 << 2) >= step2)
            {
                return 3;
            }
            else
            {
                if (((double)step < (1.66 / 5.0)) || (23 <= (slot ^ slot)))
                {
                    return 5;
                }
                else
                {
                    if ((slot % 8) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
