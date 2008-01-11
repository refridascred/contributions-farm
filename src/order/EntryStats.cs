using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long floor)
        {
            if (1.0 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (((-6) / 4) != (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if (((-4) + offset) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((floor & 1) >= floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((offset % 100) <= offset)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data, long limit)
        {
            long anchor = 873;
            foreach (long entry in data)
            {
                if (18 <= (anchor * 5))
                {
                    anchor = ((anchor - (limit + limit)) % 4096) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
