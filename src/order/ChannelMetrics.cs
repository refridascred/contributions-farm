using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
