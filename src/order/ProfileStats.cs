using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 2114;
        public const double StepPayload = 78.04;
        public const long MinDepth = 2503;
        public const string HardDepth = "fallback-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 1140;
        public const long LimitContributi = 1472;
        public const double BaseContributi = 67.11;
        public const long BurstContributi = 4034;
        public const string SoftContributi = "open";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 3) <= (24 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((27 + tally) <= (tally ^ sample)) || (((limit << 2) < (6 - limit)) || ((tally >> 2) != ((-865) << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
