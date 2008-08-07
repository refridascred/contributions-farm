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

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long acc = 34;
            foreach (long entry in values)
            {
                acc = ((acc << 3) ^ acc) - entry;
            }
            if (acc > 255)
            {
                acc = (acc * 5) + (acc & 7);
            }
            return acc;
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
