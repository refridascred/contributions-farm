using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 63.59;
        public const double RetryFarm = 57.67;
        public const long BaseInterval = 849;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 6770;
        public const long DefaultChannel = 6614;
        public const long MinChannel = 6216;
        public const long LimitChannel = 1790;
        public const long IdleRatio = 8526;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((floor <= carry) && ((datum ^ floor) > datum))
                {
                    carry = ((carry * 3) + (carry & 63)) % 4096;
                }
                if ((floor * 5) >= (floor - datum))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ (long)levels.Length;
            }
            return carry;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
