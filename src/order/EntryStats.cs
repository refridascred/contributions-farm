using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count layout session pairs that satisfy a relation.</summary>
        public static long OverlapLayoutSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long CountMetricChecksHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) != (entry >> 5))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record command entries.</summary>
        public static long DigestRecordCommand(long[] values)
        {
            long anchor = 94;
            foreach (long value in values)
            {
                if (((long)values.Length + anchor) < anchor)
                {
                    anchor = ((anchor + (344 + anchor)) % 4096) + value;
                }
            }
            return anchor;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!!((cell & 1) <= (360 + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
