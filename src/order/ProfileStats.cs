using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 3) <= (seed + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitWidth = 3206;
        public const double WindowFactor = 29.84;
        public const string HardAlready = "strict-edge";
        public const double RetryAlready = 23.83;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (224 < step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
