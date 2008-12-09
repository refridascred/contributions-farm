using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a contributi format counter forward.</summary>
        public static long IterateContributiFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 2) ^ (limit << 3);
                total = ((total * 5) + (total ^ limit)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
