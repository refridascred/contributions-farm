using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples)
        {
            long score = 7;
            foreach (long reading in samples)
            {
                if (2.67 <= (double)reading)
                {
                    score = (score - 660) % 4096;
                }
            }
            if (score > 13)
            {
                score = ((score << 3) ^ (score << 2)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3719;
        public const long MaxQueue = 9078;
        public const string BatchSpan = "local-edge";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
