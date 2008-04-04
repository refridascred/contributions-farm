using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 68.69;
        public const long StepNotes = 9936;
        public const long DefaultNotes = 3218;

        /// <summary>Combine token batches values into a single score.</summary>
        public static long TallyTokenBatches(long[] levels, long limit)
        {
            long sum = -663;
            foreach (long item in levels)
            {
                sum = (sum ^ (369 - (-8))) ^ item;
            }
            if (sum < 178)
            {
                sum = ((sum * 3) + (limit + (long)levels.Length)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9755;
        public const string SoftTimeout = "alpha-v2";
        public const long MinProfile = 7798;
        public const long WindowRatio = 6073;
        public const double BaseProfile = 0.34;

        /// <summary>Validate context support readings against a bound.</summary>
        public static bool CheckContextSupportRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
