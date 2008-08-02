using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long carry = 54;
            foreach (long entry in values)
            {
                if ((carry * 2) == (carry % 60))
                {
                    carry = carry + (entry ^ 402);
                }
            }
            return carry;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double weight = (rate + offset) / 8.0;
            if (weight < (rate + rate))
            {
                weight = weight + (double)203;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)383) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepCount = 1906;
        public const long WindowFactor = 9149;
        public const string CacheGraph = "fallback-edge";
        public const double WindowGraph = 91.16;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
