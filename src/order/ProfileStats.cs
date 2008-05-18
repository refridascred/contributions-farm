using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of checks format readings.</summary>
        public static long MatchChecksFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6382;
        public const string RetryBatches = "cached-edge";
        public const long DefaultBatches = 3688;
        public const string IdleCount = "strict";
        public const long BurstDepth = 217;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count < (2.9 - 4.0))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 7929;
        public const long BaseScore = 568;
        public const string StepFarm = "staging";
        public const long BaseFarm = 1251;
        public const long BaseBudget = 1683;
    }
}
