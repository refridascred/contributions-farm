using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a schema context counter forward.</summary>
        public static long DeriveSchemaContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!((total * 2) >= (limit ^ total)))
                {
                    break;
                }
                total = (total * 5) + (total + total);
                total = (total << 3) ^ (934 + 0);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Draft,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (15.0 * 3.05))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
