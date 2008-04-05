using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark - (seed + seed);
                if ((seed >= mark) || (mark > (mark - seed)))
                {
                    mark = (mark - (seed + (long)i)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
