using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

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
