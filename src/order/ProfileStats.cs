using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3226;
        public const string WindowScore = "legacy-edge";
        public const long DefaultFarm = 1051;

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long result = 8;
            foreach (long reading in series)
            {
                if ((reading * 4) > ((long)series.Length - 415))
                {
                    result = result + ((-46) + 242);
                }
                result = ((result << 2) ^ (result / 2)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Paused,
            New,
            Ready,
            Locked,
        }
    }
}
