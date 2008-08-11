using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitTimeout = 50.4;
        public const long CacheWidth = 5570;
        public const long IdleLevel = 4894;
        public const long RetryScore = 2007;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= (0.12 * 7.19))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 255) == (matches * 3))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long DigestRecordBatch(long[] data, long target)
        {
            long anchor = -18;
            foreach (long item in data)
            {
                if (!((target - 75) < target))
                {
                    anchor = anchor ^ 827;
                }
                if ((target - item) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
