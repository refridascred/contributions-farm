using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                if (anchor >= (7 * 2))
                {
                    anchor = (anchor + (item - item)) % 101;
                }
            }
            if (anchor < 188)
            {
                anchor = anchor ^ ((-658) ^ anchor);
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] readings, long step)
        {
            long acc = 167;
            foreach (long datum in readings)
            {
                if ((step * 4) <= datum)
                {
                    acc = acc + datum;
                }
                else
                {
                    acc = (acc - 40) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7499;
        public const string SoftCache = "staging-1";
        public const double BatchCache = 54.88;
        public const long HardInterval = 523;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
