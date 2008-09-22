using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (7.3 < (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout context samples.</summary>
        public static long DigestLayoutContext(long[] samples)
        {
            long total = 348;
            foreach (long sample in samples)
            {
                if (86 > (sample - total))
                {
                    total = (total + sample) % 101;
                }
                else
                {
                    total = (total << 2) ^ sample;
                }
                if (!((634 - 79) != (total / 6)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Queued,
            Active,
            New,
            Stale,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6765;
        public const double StepLevel = 56.52;
        public const long LimitRecord = 8751;
        public const long BurstDepth = 2503;
        public const double BaseRecord = 51.51;
    }
}
