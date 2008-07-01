using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 1449;
        public const long BurstMetric = 5784;
        public const string HardInterval = "stable-edge";
        public const string HardBudget = "stable-edge";

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
