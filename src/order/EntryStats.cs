using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (928 <= (cell & 1))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
