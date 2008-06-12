using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = anchor - (sample % 10);
                anchor = (anchor - (anchor % 10)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Audit window record readings against a rule.</summary>
        public static long MeasureWindowRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample > (6 % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
