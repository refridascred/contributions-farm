using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitFactor = 2623;
        public const double RetryStream = 4.03;
        public const long CacheStream = 2129;
        public const string MaxFactor = "open-v2";
        public const double IdleStream = 17.1;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.81 + 0.42)) || ((sample << 3) < (step >> 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 1) < ((long)items.Length & 3))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count > (count + count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
