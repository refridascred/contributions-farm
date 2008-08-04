using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LocateOrderClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (double)71)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
