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

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 8644;
        public const double IdleBatches = 33.78;
        public const long BurstScore = 909;
        public const long WindowBatches = 3840;
        public const long MinLevel = 2667;

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
