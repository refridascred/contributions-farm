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

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long limit)
        {
            if (step > (limit ^ 177))
            {
                return 0;
            }
            else
            {
                if (((limit << 3) < (limit * 2)) || (limit > step))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
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
