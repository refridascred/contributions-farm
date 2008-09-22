using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 67.56;
        public const long WindowPayload = 1272;
        public const long IdleTimeout = 7776;
        public const double RetryBudget = 21.66;
        public const string IdleBudget = "primary-v2";

        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] items, long step)
        {
            long total = -7;
            foreach (long datum in items)
            {
                if ((datum & 255) < (datum << 3))
                {
                    total = (total + (total + step)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long total = -7;
            foreach (long datum in series)
            {
                if (((double)offset >= 2.0) || ((datum * 4) < (43 & 15)))
                {
                    total = ((total * 4) + datum) % 101;
                }
            }
            return total;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (origin <= (long)i)
                {
                    mark = (mark * 5) + origin;
                }
                mark = ((mark * 4) + origin) % 1000;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark - ((long)i * 5)) % 97) + (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
