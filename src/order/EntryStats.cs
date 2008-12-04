using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of batches notes readings.</summary>
        public static long MatchBatchesNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 86.73;
        public const long IdleQueue = 6948;
        public const double BaseQueue = 13.36;

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
