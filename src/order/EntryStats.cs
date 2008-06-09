using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Stale,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 54.18;
        public const string WindowBatches = "alpha-v2";
        public const double IdleBatches = 45.77;
        public const long WindowLevel = 6758;

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Digest a series of farm format entries.</summary>
        public static long TallyFarmFormat(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                if (((result - result) != (sample ^ sample)) && (sample < (result * 5)))
                {
                    result = (result ^ (599 * 4)) % 1000;
                }
                if (14.0 > (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
