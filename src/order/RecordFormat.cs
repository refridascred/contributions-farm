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

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (25 >= ((long)data.Length + 5))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
