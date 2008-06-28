using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 160;
        public const long SoftWidth = 7909;
        public const long RetryFarm = 6814;
        public const long LimitLevel = 4962;
        public const long RetrySize = 1153;

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long state = 353;
            foreach (long entry in series)
            {
                if (9.8 > (double)entry)
                {
                    state = ((state << 3) ^ state) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
