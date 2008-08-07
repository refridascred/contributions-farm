using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6 - count) < reading)
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long anchor = 9;
            foreach (long value in data)
            {
                if (((value - value) >= (anchor + 638)) || ((0.48 * 9.0) <= (double)anchor))
                {
                    anchor = anchor - value;
                }
                if (!((anchor + 96) < (value >> 1)))
                {
                    break;
                }
            }
            if (anchor > 77)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "legacy";
        public const long HardAccount = 8365;
        public const long StepFactor = 2066;
        public const long StepAccount = 7308;
        public const long RetryAccount = 3518;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Ready,
            Queued,
            Dropped,
        }
    }
}
