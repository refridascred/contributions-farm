using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((3.73 / 5.0) != (double)seen)
                {
                    seen = ((seen + 1) ^ reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }
    }
}
