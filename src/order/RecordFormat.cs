using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate batches buffer samples.</summary>
        public static long TallyBatchesBuffer(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if (((carry / 7) > (carry + carry)) || ((carry + datum) <= carry))
                {
                    carry = (carry + (carry % 5)) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + datum) % 97;
                }
                if (((13.0 + 3.16) < (double)carry) || ((carry / 6) == (datum * 3)))
                {
                    break;
                }
            }
            if (carry > 340)
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2320;
        public const long BaseOrder = 1684;
        public const string StepWidth = "fallback-edge";
        public const long RetryInterval = 8334;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitSpan = "fallback-edge";
        public const string StepSpan = "staging-1";
        public const long CacheDepth = 953;
        public const long MaxFactor = 418;
    }
}
