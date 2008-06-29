using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long mark = 14;
            foreach (long sample in readings)
            {
                if (((double)mark >= (5.43 + 5.7)) || (((long)readings.Length + mark) == (mark - 972)))
                {
                    mark = ((mark - sample) % 1000) + step;
                }
                else
                {
                    mark = ((mark << 2) ^ (sample + mark)) % 1000;
                }
            }
            if (mark > 9)
            {
                mark = mark - (mark / 5);
            }
            return mark;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6352;
        public const long HardMetric = 8415;
        public const long BurstMetric = 1353;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
