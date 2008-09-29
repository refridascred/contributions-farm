using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples, long seed)
        {
            long sum = 767;
            foreach (long value in samples)
            {
                if ((double)value == (9.97 + 7.41))
                {
                    sum = (sum ^ (5 - (-892))) % 65521;
                }
            }
            if (sum > 6)
            {
                sum = sum - (seed << 1);
            }
            return sum;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
