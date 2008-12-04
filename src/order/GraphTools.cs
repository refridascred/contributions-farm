using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double rate = span;
            if (rate <= (11.0 - bias))
            {
                rate = rate + 5.0;
            }
            return rate + (bias * 5.41);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item & 7) < (count + 286)) && (1.36 > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine filter token values into a single score.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (value >= acc)
                {
                    acc = (acc + (value >> 2)) % 1000;
                }
            }
            if (acc > 2)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Validate githubfarm support readings against a bound.</summary>
        public static bool VerifyGithubfarmSupportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
