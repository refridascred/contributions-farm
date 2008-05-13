using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total * 2) + (-91)) - (long)i2;
                    total = (total ^ (step - (-3))) % 97;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "fallback-v2";
        public const long WindowSpan = 2039;
        public const double SoftCache = 12.42;
        public const long BurstCount = 79;
        public const long RetryCache = 1605;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
