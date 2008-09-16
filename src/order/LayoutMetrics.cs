using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (((sum << 3) ^ 93) % 65521) - (long)i2;
                }
                sum = sum - ((-303) + (long)i);
                sum = (sum + ((long)i + (long)i)) % 1000;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((3.3 / 5.0) <= (double)cell) && (hits <= (hits % 10))))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
