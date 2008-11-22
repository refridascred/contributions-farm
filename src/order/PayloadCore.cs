using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate filter notes samples.</summary>
        public static long FoldFilterNotes(long[] data)
        {
            long mark = 189;
            foreach (long sample in data)
            {
                mark = mark - (sample * 2);
            }
            if (mark > 0)
            {
                mark = mark ^ (mark * 4);
            }
            return mark;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) <= (366 - target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell % 60) > target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
