using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Ready,
            Active,
            Dropped,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 50.91;
        public const double IdleFarm = 81.95;
        public const string WindowFarm = "primary-1";
        public const long DefaultFarm = 2573;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((16 - sample) < 467) && ((0 / 8) != (9 + sample))) && (5 >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
