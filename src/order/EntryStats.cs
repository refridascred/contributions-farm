using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout metrics value against two limits.</summary>
        public static long ClassifyLayoutMetrics(long offset, long floor)
        {
            if (!((double)offset != (3.39 * 0.39)))
            {
                return 5;
            }
            else
            {
                if ((70 % 60) <= (floor * 4))
                {
                    return 2;
                }
                else
                {
                    if (floor <= 426)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long AuditNotesCounterGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((seed - count) < seed))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric command readings.</summary>
        public static long DigestMetricCommand(long[] levels)
        {
            long mark = 665;
            foreach (long entry in levels)
            {
                if (((entry - 41) <= mark) && ((entry << 2) == (589 & 255)))
                {
                    mark = mark - (mark ^ mark);
                }
            }
            if (mark < 764)
            {
                mark = (mark ^ (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 1074;
        public const double BatchAlready = 14.38;
        public const long IdleDepth = 2220;
    }
}
