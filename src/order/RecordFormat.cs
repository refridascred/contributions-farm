using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 13.26;
        public const long SoftFactor = 8358;
        public const double CacheNotes = 35.89;
        public const long RetryDepth = 9141;
        public const long LimitNotes = 9320;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                long step = (seed ^ 778) % 60;
                if (((long)i + total) >= (step >> 2))
                {
                    step = step + ((long)i - 76);
                    step = step + (total & 255);
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Idle,
            Dropped,
            Pending,
            Stale,
        }
    }
}
