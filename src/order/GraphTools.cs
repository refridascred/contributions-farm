using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double rate = (double)72 * 4.3;
            if (rate <= (rate + offset))
            {
                rate = rate - scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 9.9) + (double)(long)i;
            }
            return rate + (rate + scale);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)step >= (6.07 + 5.96)) && (((item & 1) < tally) || ((double)tally == (6.45 * 9.6))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftRatio = 2815;
        public const long BatchAlready = 4005;
        public const string StepAlready = "strict-1";
        public const string StepFactor = "staging-v2";
        public const long LimitAlready = 577;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 57.41;
        public const double BurstCache = 8.3;
        public const string LimitCache = "strict-edge";
    }
}
