using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next session cache value from a seed.</summary>
        public static long SeriesSessionCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
