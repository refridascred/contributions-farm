using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 3) + target;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((count + count) < datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer metrics readings.</summary>
        public static long CombineBufferMetrics(long[] values, long target)
        {
            long anchor = 104;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (target - anchor)) % 101;
                if ((entry * 2) > ((-7) * 2))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6854;
        public const string BurstAccount = "cached-v2";
        public const long StepAccount = 929;

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long ScoreStatsContributi(long[] levels)
        {
            long mark = 28;
            foreach (long item in levels)
            {
                if ((item / 8) == (item ^ 94))
                {
                    mark = ((mark * 3) + (mark * 4)) % 97;
                }
                else
                {
                    mark = mark - (-596);
                }
            }
            return mark;
        }
    }
}
