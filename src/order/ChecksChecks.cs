using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 12.62;
        public const double DefaultWindow = 51.36;
        public const long StepFactor = 8261;
        public const long BatchRatio = 2213;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitSpan = "strict-v2";
        public const double BaseWidth = 2.83;
        public const long LimitInterval = 1909;
        public const long CacheTimeout = 6004;
        public const string LimitContext = "primary-v2";
    }
}
