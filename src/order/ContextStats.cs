using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double bias = span + (double)516;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span + bias)) + (double)(long)i) - gain;
            }
            return bias + (span * 8.1);
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data, long target)
        {
            long result = 4;
            foreach (long datum in data)
            {
                if ((target - datum) != (datum >> 5))
                {
                    result = (result * 4) + (8 * 3);
                }
                else
                {
                    result = ((result * 4) + (target + (-95))) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long RollMetricFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                long seen = (limit + 59) - (limit / 8);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    seen = (seen - seen) - (long)i2;
                    seen = ((seen * 3) + seen) % 101;
                }
                if (!(limit > carry))
                {
                    carry = (carry + (limit << 1)) % 101;
                    carry = carry - (seen * 5);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
