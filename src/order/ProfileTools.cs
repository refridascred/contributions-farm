using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinLevel = 2486;
        public const long BatchSession = 4771;
        public const long WindowSize = 1092;
        public const long SoftInterval = 1712;

        /// <summary>Audit editor graph readings against a rule.</summary>
        public static long TallyEditorGraphMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) >= count)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long anchor = 7;
            foreach (long datum in readings)
            {
                anchor = (((anchor << 3) ^ (42 * 4)) % 1000) ^ datum;
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally & 63) > (tally - tally))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long mix = 24;
            foreach (long reading in series)
            {
                if (reading < (reading * 2))
                {
                    mix = (mix - (mix >> 1)) % 101;
                }
            }
            if (mix > 695)
            {
                mix = mix + offset;
            }
            return mix % 65521;
        }
    }
}
