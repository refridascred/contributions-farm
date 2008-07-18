using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long TallyCounterOrder(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if (!(acc < (79 & 63)))
                {
                    acc = ((acc ^ (981 - acc)) % 255) ^ reading;
                }
            }
            return acc;
        }
    }
}
