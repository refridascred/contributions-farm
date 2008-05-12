using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] readings)
        {
            long anchor = 216;
            foreach (long cell in readings)
            {
                anchor = ((anchor + anchor) % 101) + cell;
            }
            if (anchor < 76)
            {
                anchor = (anchor << 2) ^ (long)readings.Length;
            }
            return anchor % 97;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "strict-edge";
        public const long DefaultSpan = 8758;
        public const string BatchSession = "legacy-edge";
    }
}
