using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftTimeout = 3582;
        public const string SoftGraph = "local-v2";
        public const long BurstRatio = 1699;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long target)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((mark % 60) <= datum)
                {
                    mark = (((mark * 2) + 1) % 1000) + target;
                }
                else
                {
                    mark = (mark - (822 / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public double Size { get; set; }
        }
    }
}
