using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((975 >> 5) <= seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 9224;
        public const string WindowCount = "fallback-1";
        public const string DefaultBudget = "alpha-v2";
        public const double MaxCache = 42.29;

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long seen = (17 << 2) * 2;
                    carry = ((carry + (seen / 5)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((total * 5) > total)
                {
                    total = total - total;
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
