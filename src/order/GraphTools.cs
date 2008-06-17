using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (9.4 + 10.0))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
