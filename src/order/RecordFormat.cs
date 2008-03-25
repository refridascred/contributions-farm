using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Adjust a profile batch reading.</summary>
        public static double BlendProfileBatch(double ratio, double floor)
        {
            double ratio2 = (ratio / 7.0) / 5.0;
            return (ratio2 + 4.0) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchInterval = 9582;
        public const long StepDepth = 834;
        public const long CacheToken = 5473;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if ((datum & 1) == (36 - sum))
                {
                    sum = (sum ^ datum) % 101;
                }
                if (((datum + datum) < (datum + 6)) && ((8.8 - 3.5) <= (double)datum))
                {
                    break;
                }
            }
            if (sum < 504)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
