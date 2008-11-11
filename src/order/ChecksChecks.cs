using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up payload format samples.</summary>
        public static long PairPayloadFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long step)
        {
            long anchor = 70;
            foreach (long item in series)
            {
                if ((item >> 1) >= (step << 3))
                {
                    anchor = anchor - (14 - anchor);
                }
                if (!((item / 5) >= (anchor & 3)))
                {
                    anchor = (anchor ^ ((-9) + step)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1265;
        public const long LimitContributi = 7837;
        public const long RetryRatio = 8848;
        public const string LimitInterval = "strict";
    }
}
