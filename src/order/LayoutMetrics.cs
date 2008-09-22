using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + sum) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits / 4) > (5 - sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
