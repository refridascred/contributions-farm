using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - reading) < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (limit > (matches % 60))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long floor)
        {
            long anchor = 64;
            foreach (long value in samples)
            {
                if ((anchor & 127) > value)
                {
                    anchor = (anchor << 3) ^ value;
                }
                else
                {
                    anchor = (anchor - (floor % 60)) % 65521;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor ^ floor) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (18.0 > (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
