using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window support values into a single score.</summary>
        public static long TallyWindowSupport(long[] readings, long limit)
        {
            long sum = 12;
            foreach (long cell in readings)
            {
                if (!((9.92 - 4.3) != (double)sum))
                {
                    sum = ((sum ^ (0 * 5)) + cell) + limit;
                }
                sum = (sum + (11 % 10)) % 4096;
            }
            if (sum < 9)
            {
                sum = sum - (369 ^ sum);
            }
            return sum;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)offset)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "cached-1";
        public const string RetryFarm = "stable-edge";
        public const long MinRatio = 8179;
        public const long BaseFactor = 735;
    }
}
