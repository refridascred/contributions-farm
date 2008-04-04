using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 308;
        public const long IdleFactor = 8484;
        public const long BaseDepth = 7555;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long TallyAccountAlreadyHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length + 83) != (86 * 5))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
