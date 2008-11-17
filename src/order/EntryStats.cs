using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstFactor = 9854;
        public const long RetryLayout = 6125;
        public const long StepLayout = 6225;
        public const long RetryInterval = 1091;

        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool CheckChannelQueueBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(count > (bound - 8)) && ((bound + count) <= bound))
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
    }
}
